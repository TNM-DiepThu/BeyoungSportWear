document.addEventListener('DOMContentLoaded', function () {
    const productForm = document.getElementById('productForm');
    productForm.addEventListener('submit', function (event) {
        event.preventDefault();
    });

    const btnSave = document.getElementById('btn_saveproductdetails');
    btnSave.addEventListener('click', function () {
        var product_key = document.getElementById("product_key").value;
        var product_product = document.getElementById("product_name").value;
        var product_category = document.getElementById("category_name").value;
        var product_manufacture = document.getElementById("manufacture_name").value;
        var product_material = document.getElementById("material_name").value;
        var select_brand = document.getElementById("brand_name").value;
        var product_style = document.getElementById("product_style").value;
        var product_origin = document.getElementById("product_origin").value;
        var product_description = document.getElementById("product_description").value;
        var productId = guid(); 

        var productData = {
            CreateBy: "John Doe",
            ID: productId,
            KeyCode: product_key,
            ProductName: product_product,
            CategoryName: product_category,
            ManufacturersName: product_manufacture,
            MaterialName: product_material,
            BrandName: select_brand,
            Style: product_style,
            Origin: product_origin,
            Description: product_description,
            ImagePaths: [],
            OptionsCreateVM: createOptionsData(),
        };

        saveProduct(productData);
    });

    async function uploadImages(productId, optionsId) {
        const imageUploads = document.querySelectorAll('.custom-file-input');
        const formData = new FormData();

        for (let i = 0; i < imageUploads.length; i++) {
            const file = imageUploads[i].files[0];
            formData.append('files', file);
        }

        formData.append('IDProductDetails', productId);
        formData.append('IDOptions', optionsId);

        try {
            const response = await xhrRequest('https://localhost:7241/api/images/upload_images', 'POST', formData);
            const imagePaths = JSON.parse(response);
            const imageEntities = imagePaths.map((image, index) => {
                return {
                    ID: guid(),
                    IDProductDetails: productId,
                    IDOptions: options[index].ID,
                    Status: 1,
                    Path: image.secure_url,
                    CreateBy: 'John Doe',
                    CreateDate: new Date().toISOString()
                };
            });

            await saveImages(imageEntities);

        } catch (error) {
            Swal.fire({
                icon: 'error',
                title: 'Lỗi khi tải lên ảnh',
                text: 'Có lỗi xảy ra khi tải lên ảnh sản phẩm!'
            });
            console.error('Đã xảy ra lỗi khi tải lên ảnh:', error);
        }
    }

    async function saveImages(imageEntities) {
        try {
            const response = await xhrRequest('https://localhost:7241/api/images/saveImages', 'POST', JSON.stringify(imageEntities), true);
            Swal.fire({
                icon: 'success',
                title: 'Lưu thành công',
                text: 'Dữ liệu đã được lưu thành công!'
            }).then(() => {
                window.location.reload();
            });

        } catch (error) {
            Swal.fire({
                icon: 'error',
                title: 'Lưu thất bại',
                text: 'Có lỗi xảy ra khi lưu ảnh vào cơ sở dữ liệu!'
            });
            console.error('Đã xảy ra lỗi khi lưu ảnh vào cơ sở dữ liệu:', error);
        }
    }

    function xhrRequest(url, method, data, isJSON = false) {
        return new Promise((resolve, reject) => {
            const xhr = new XMLHttpRequest();
            xhr.open(method, url, true);

            if (isJSON) {
                xhr.setRequestHeader('Content-Type', 'application/json');
            }

            xhr.onload = function () {
                if (xhr.status >= 200 && xhr.status < 300) {
                    resolve(xhr.responseText);
                } else {
                    reject(xhr.statusText);
                }
            };

            xhr.onerror = function () {
                reject(xhr.statusText);
            };

            xhr.send(data);
        });
    }
    function createOptionsData() {
        const optionsData = [];
        const rows = document.getElementById('classificationBody').getElementsByTagName('tr');
        for (let i = 0; i < rows.length; i++) {
            const cells = rows[i].getElementsByTagName('td');
            if (cells.length === 7) {
                const color = cells[1].textContent.trim();
                const size = cells[2].textContent.trim();
                const giaNhap = cells[3].querySelector('input').value;
                const giaBan = cells[4].querySelector('input').value;
                const soLuong = cells[5].querySelector('input').value;
                const imagePreviewId = cells[0].id;
                const imagePaths = document.getElementById(imagePreviewId).querySelector('img')?.src || '';

                const option = {
                    ID = guid(),
                    CreateBy: "John Doe",
                    ColorName: color,
                    SizesName: size,
                    StockQuantity: parseInt(soLuong) || 0,
                    CostPrice: parseFloat(giaNhap) || 0,
                    RetailPrice: parseFloat(giaBan) || 0,
                    Discount: null,
                    ImagePaths: imagePaths,
                    Status: 1,
                };

                optionsData.push(option);
            }
        }
        return optionsData;
    }

    function saveProduct(productData) {

        var xhr = new XMLHttpRequest();
        var url = 'https://localhost:7241/api/ProductDetails/productdetails_create';
        xhr.open('POST', url, true);
        xhr.setRequestHeader('Content-Type', 'application/json');
        xhr.upload.addEventListener('progress', function (event) {
            if (event.lengthComputable) {
                const percentComplete = (event.loaded / event.total) * 100;
                console.log('Tiến độ tải lên: ' + percentComplete.toFixed(2) + '%');
                Swal.fire({
                    title: 'Đang tải lên...',
                    html: 'Tiến độ: ' + percentComplete.toFixed(2) + '%',
                    timerProgressBar: true,
                    didOpen: () => {
                        Swal.showLoading();
                    }
                });
            }
        });
        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4) {
                if (xhr.status === 200) {
                    var response = JSON.parse(xhr.responseText);
                    uploadImages(response.productId, response.options);
                } else {
                    var errorMessage = 'Có lỗi xảy ra trong quá trình lưu dữ liệu!';
                    if (xhr.responseText) {
                        errorMessage = `Lỗi từ máy chủ: ${xhr.responseText}`;
                    }
                    Swal.fire({
                        icon: 'error',
                        title: 'Lưu thất bại',
                        text: errorMessage
                    });
                    console.error('Đã xảy ra lỗi khi lưu sản phẩm:', xhr.status);
                }
            }
        };
        xhr.onerror = function () {
            Swal.fire({
                icon: 'error',
                title: 'Lưu thất bại',
                text: 'Đã xảy ra lỗi khi gửi yêu cầu lưu sản phẩm!'
            });
            console.error('Đã xảy ra lỗi khi gửi yêu cầu lưu sản phẩm!');
        };
        xhr.send(JSON.stringify(productData));
    }

    const addColorButton = document.getElementById('addColorButton');
    addColorButton.addEventListener('click', function () {
        addColor();
    });

    const addSizeButton = document.getElementById('addSizeButton');
    addSizeButton.addEventListener('click', function () {
        addSize();
    });

    function guid() {
        return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
            var r = Math.random() * 16 | 0,
                v = c === 'x' ? r : (r & 0x3 | 0x8);
            return v.toString(16);
        });
    }
});


let colors = [];
let sizes = [];

function addColor() {
    const color = document.getElementById('color').value;
    if (color && !colors.includes(color)) {
        colors.push(color);
        updateColors();
        updateTable();
        document.getElementById('color').value = '';
    } else {
        Swal.fire({
            icon: 'error',
            title: 'Lỗi!',
            text: 'Vui lòng nhập màu hợp lệ hoặc màu đã tồn tại.'
        });
    }
}
function addSize() {
    const size = document.getElementById('size').value;
    if (size && !sizes.includes(size)) {
        sizes.push(size);
        updateSizes();
        updateTable();
        document.getElementById('size').value = '';
    } else {
        Swal.fire({
            icon: 'error',
            title: 'Lỗi!',
            text: 'Vui lòng nhập size hợp lệ hoặc size đã tồn tại.'
        });
    }
}
function updateColors() {
    const addedColors = document.getElementById('addedColors');
    addedColors.innerHTML = '';
    colors.forEach(color => {
        const span = document.createElement('span');
        span.textContent = color;
        addedColors.appendChild(span);
    });
}
function updateSizes() {
    const addedSizes = document.getElementById('addedSizes');
    addedSizes.innerHTML = '';
    sizes.forEach(size => {
        const span = document.createElement('span');
        span.textContent = size;
        addedSizes.appendChild(span);
    });
}
function updateTable() {
    const tableBody = document.getElementById('classificationBody');
    tableBody.innerHTML = '';

    if (colors.length === 0 || sizes.length === 0) {
        const row = document.createElement('tr');
        const cell = document.createElement('td');
        cell.colSpan = 7;
        cell.textContent = 'Không có dữ liệu';
        cell.className = 'no-data';
        row.appendChild(cell);
        tableBody.appendChild(row);
        return;
    }

    colors.forEach(color => {
        sizes.forEach(size => {
            const row = document.createElement('tr');
            const imagePreviewId = `imagePreview-${color}-${size}`;
            row.innerHTML = `
             <td class="image-preview-options" id="${imagePreviewId}">
                <input type="file" id="image-upload-${imagePreviewId}" class="custom-file-input">
            </td>


                <td>${color}</td>
                <td>${size}</td>
                <td><input id="giaNhap" type="text" placeholder="Nhập giá nhập"></td>
                <td><input id="giaBan" type="text" placeholder="Nhập giá bán"></td>
                <td><input id="soLuong" type="text" placeholder="0"></td>
                <td><button class="remove-button" onclick="removeRow(this)">Xóa</button></td>
            `;
            tableBody.appendChild(row);
        });
    });
}
function applyAll() {
    const inputNhap = document.getElementById('giaNhap').value;
    const inputBan = document.getElementById('giaBan').value;
    const inputSoLuong = document.getElementById('soLuong').value;

    const rows = document.querySelectorAll('#classificationBody tr');

    if (rows.length > 0) {
        rows.forEach(row => {
            const inputs = row.querySelectorAll('input[type="text"]');
            inputs[0].value = inputNhap;
            inputs[1].value = inputBan;
            inputs[2].value = inputSoLuong;
        });

        Swal.fire({
            icon: 'success',
            title: 'Thành công!',
            text: 'Đã áp dụng cho tất cả phân loại.'
        });
    } else {
        Swal.fire({
            icon: 'error',
            title: 'Lỗi!',
            text: 'Không có dữ liệu để áp dụng.'
        });
    }
}
function removeRow(button) {
    const row = button.parentElement.parentElement;
    const color = row.cells[1].textContent;
    const size = row.cells[2].textContent;

    row.remove();

    const rows = document.querySelectorAll('#classificationBody tr');
    let colorExists = false;
    let sizeExists = false;

    rows.forEach(row => {
        if (row.cells[1].textContent === color) {
            colorExists = true;
        }
        if (row.cells[2].textContent === size) {
            sizeExists = true;
        }
    });

    if (!colorExists) {
        colors = colors.filter(c => c !== color);
        updateColors();
    }

    if (!sizeExists) {
        sizes = sizes.filter(s => s !== size);
        updateSizes();
    }

    if (rows.length === 0) {
        const tableBody = document.getElementById('classificationBody');
        const row = document.createElement('tr');
        const cell = document.createElement('td');
        cell.colSpan = 7;
        cell.textContent = 'Không có dữ liệu';
        cell.className = 'no-data';
        row.appendChild(cell);
        tableBody.appendChild(row);
    }
}
document.addEventListener("DOMContentLoaded", function () {
    function loadData(url, selectId, defaultText) {
        var xhr = new XMLHttpRequest();
        xhr.open("GET", url, true);
        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4 && xhr.status === 200) {
                var data = JSON.parse(xhr.responseText);
                var selectElement = document.getElementById(selectId);
                selectElement.innerHTML = '';

                var defaultOption = document.createElement('option');
                defaultOption.text = defaultText;
                selectElement.add(defaultOption);

                data.forEach(function (item) {
                    var option = document.createElement('option');
                    option.value = item.id;
                    option.text = item.name;
                    option.setAttribute('data-name', item.name);
                    selectElement.add(option);
                });
            } else if (xhr.readyState === 4) {
                console.error('Error:', xhr.statusText);
            }
        };
        xhr.send();
    }

    function addChangeListener(selectId, inputId) {
        document.getElementById(selectId).addEventListener('change', function () {
            var selectedOption = this.options[this.selectedIndex];
            var inputElement = document.getElementById(inputId);
            if (selectedOption.value) {
                inputElement.value = selectedOption.getAttribute('data-name');
                inputElement.readOnly = true;
            } else {
                inputElement.value = '';
                inputElement.readOnly = false;
            }
        });
    }

    loadData("https://localhost:7241/api/Product/GetAllActive", 'product_product', '-- Chọn sản phẩm --');
    addChangeListener('product_product', 'product_name');

    loadData("https://localhost:7241/api/Material/GetAllActive", 'product_material', '-- Chọn chất liệu --');
    addChangeListener('product_material', 'material_name');

    loadData("https://localhost:7241/api/Brand/GetAllActive", 'product_brand', '-- Chọn thương hiệu --');
    addChangeListener('product_brand', 'brand_name');

    loadData("https://localhost:7241/api/Manufacturer/GetAllActive", 'product_manufacture', '-- Chọn nhà sản xuất --');
    addChangeListener('product_manufacture', 'manufacture_name');
});
document.addEventListener("DOMContentLoaded", function () {
    var imageUpload = document.getElementById('image-upload');
    imageUpload.addEventListener('change', function () {
        var files = this.files;
        for (var i = 0; i < files.length; i++) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var imagePreview = document.createElement('label');
                imagePreview.className = 'image-preview-item';

                var image = document.createElement('img');
                image.src = e.target.result;
                image.alt = 'Preview';
                imagePreview.appendChild(image);

                var removeBtn = document.createElement('span');
                removeBtn.className = 'remove-image';
                removeBtn.innerHTML = '&times;';
                removeBtn.style.position = 'absolute';
                removeBtn.style.top = '5px';
                removeBtn.style.right = '5px';
                removeBtn.style.cursor = 'pointer';
                removeBtn.style.backgroundColor = 'rgba(255, 255, 255, 0.8)';
                removeBtn.style.borderRadius = '50%';
                removeBtn.style.padding = '5px';
                removeBtn.addEventListener('click', function () {
                    this.parentElement.remove();
                });
                imagePreview.appendChild(removeBtn);

                var imageContainer = document.querySelector('.image-preview');
                imageContainer.appendChild(imagePreview);
            };
            reader.readAsDataURL(files[i]);
        }
    });
});
