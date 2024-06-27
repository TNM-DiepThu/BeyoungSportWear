
//document.addEventListener('DOMContentLoaded', function () {
//    const productForm = document.getElementById('productForm');
//    productForm.addEventListener('submit', function (event) {
//        event.preventDefault(); 
//    });

//    const btnSave = document.getElementById('btn_saveproductdetails');
//    btnSave.addEventListener('click', function () {
//        var product_product = document.getElementById("product_name").value;
//        var product_category = document.getElementById("category_name").value;
//        var product_manufacture = document.getElementById("manufacture_name").value;
//        var product_material = document.getElementById("material_name").value;
//        var select_brand = document.getElementById("brand_name").value;
//        var product_style = document.getElementById("product_style").value;
//        var product_origin = document.getElementById("product_origin").value;
//        var product_description = document.getElementById("product_description").value;
//        var product_images = document.getElementById("image-upload").files;
//        console.log(product_images)
//        var productId = guid();
//        if (!product_product || !product_category || !product_manufacture || !product_material || !select_brand || !product_style || !product_origin || !product_description) {
//            Swal.fire({
//                icon: 'error',
//                title: 'Lỗi',
//                text: 'Vui lòng điền đầy đủ tất cả các trường thông tin!',
//            });
//            return;
//        }

//        Swal.fire({
//            title: 'Xác nhận',
//            text: 'Bạn có muốn lưu sản phẩm này?',
//            icon: 'question',
//            showCancelButton: true,
//            confirmButtonText: 'Đồng ý',
//            cancelButtonText: 'Hủy bỏ'
//        }).then((result) => {
//            if (result.isConfirmed) {
//                Swal.fire({
//                    title: 'Đang lưu sản phẩm...',
//                    html: 'Vui lòng chờ...',
//                    timerProgressBar: true,
//                    didOpen: () => {
//                        Swal.showLoading();
//                    }
//                });

//                var productData = {
//                    CreateBy: "John Doe",
//                    ID: productId,
//                    ProductName: product_product,
//                    CategoryName: product_category,
//                    ManufacturersName: product_manufacture,
//                    MaterialName: product_material,
//                    BrandName: select_brand,
//                    Style: product_style,
//                    Origin: product_origin,
//                    Description: product_description,
//                    ImagePaths: [], 
//                    OptionsCreateVM: createOptionsData(),
//                };

//                saveProduct(productData, product_images);
//                console.log(productData);
//                console.log(product_images);

//            }
//        });
//    });
//    function uploadImages(productId, product_images) {

//        if (product_images.length === 0) {
//            console.error('Không có tệp nào để tải lên.');
//            return;
//        }

//        var formData = new FormData();
//        var maxFileSize = 2 * 1024 * 1024; 
//        for (var i = 0; i < product_images.length; i++) {
//            var file = product_images[i];
//            if (file.size > maxFileSize) {
//                Swal.fire({
//                    icon: 'error',
//                    title: 'Tệp quá lớn',
//                    text: 'Kích thước tệp ' + file.name + ' vượt quá giới hạn 2MB.'
//                });
//                return;
//            }
//            formData.append('Path', file);
//        }

//        formData.append('IDProductDetails', productId);
//        formData.append('CreateBy', 'John Doe'); 
//        formData.append('Status', 1);


//        var xhr = new XMLHttpRequest();
//        xhr.open('POST', 'https://localhost:7241/api/images/upload_images', true);
//        xhr.onreadystatechange = function () {
//            if (xhr.readyState === 4) {
//                if (xhr.status === 200) {
//                    console.log('Ảnh đã được tải lên thành công');
//                    Swal.fire({
//                        icon: 'success',
//                        title: 'Thành công',
//                        text: 'Sản phẩm và ảnh đã được lưu thành công!'
//                    });
//                } else {
//                    var errorMessage = 'Có lỗi xảy ra trong quá trình tải lên ảnh!';
//                    if (xhr.responseText) {
//                        errorMessage = `Lỗi từ máy chủ: ${xhr.responseText}`;
//                    }
//                    Swal.fire({
//                        icon: 'error',
//                        title: 'Tải ảnh thất bại',
//                        text: errorMessage
//                    });
//                    console.error('Đã xảy ra lỗi khi tải lên ảnh:', xhr.responseText);
//                }
//            }
//        };
//        xhr.onerror = function () {
//            Swal.fire({
//                icon: 'error',
//                title: 'Tải ảnh thất bại',
//                text: 'Đã xảy ra lỗi khi gửi yêu cầu tải ảnh!'
//            });
//            console.error('Đã xảy ra lỗi khi gửi yêu cầu tải ảnh!');
//        };
//        xhr.send(formData);
//    }
//    function saveProduct(productData, product_images) {
//        var xhr = new XMLHttpRequest();
//        var url = 'https://localhost:7241/api/ProductDetails/productdetails_create';
//        xhr.open('POST', url, true);
//        xhr.setRequestHeader('Content-Type', 'application/json');
//        xhr.onreadystatechange = function () {
//            if (xhr.readyState === 4) {
//                if (xhr.status === 200) {
//                    var response = JSON.parse(xhr.responseText);
//                    console.log('Đã lưu sản phẩm thành công:', response);

//                    uploadImages(productData.ID, product_images);
//                } else {
//                    var errorMessage = 'Có lỗi xảy ra trong quá trình lưu dữ liệu!';
//                    if (xhr.responseText) {
//                        errorMessage = `Lỗi từ máy chủ: ${xhr.responseText}`;
//                    }
//                    Swal.fire({
//                        icon: 'error',
//                        title: 'Lưu thất bại',
//                        text: errorMessage
//                    });
//                    console.error('Đã xảy ra lỗi khi lưu sản phẩm:', xhr.status);
//                }
//            }
//        };
//        xhr.onerror = function () {
//            Swal.fire({
//                icon: 'error',
//                title: 'Lưu thất bại',
//                text: 'Đã xảy ra lỗi khi gửi yêu cầu lưu sản phẩm!'
//            });
//            console.error('Đã xảy ra lỗi khi gửi yêu cầu lưu sản phẩm!');
//        };
//        xhr.send(JSON.stringify(productData));
//    }

//    function createOptionsData() {
//        const optionsData = [];
//        const rows = document.getElementById('classificationBody').getElementsByTagName('tr');
//        for (let i = 0; i < rows.length; i++) {
//            const cells = rows[i].getElementsByTagName('td');
//            if (cells.length === 7) {
//                const color = cells[1].textContent.trim();
//                const size = cells[2].textContent.trim();
//                const giaNhap = cells[3].querySelector('input').value;
//                const giaBan = cells[4].querySelector('input').value;
//                const soLuong = cells[5].querySelector('input').value;


//                const imagePreviewId = cells[0].id;
//                const imagePaths = cells[0].querySelector('img')?.src || '';

//                const option = {
//                    ID: guid(),
//                    CreateBy: "John Doe",
//                    ColorName: color,
//                    SizesName: size,
//                    StockQuantity: parseInt(soLuong) || 0,
//                    CostPrice: parseFloat(giaNhap) || 0,
//                    RetailPrice: parseFloat(giaBan) || 0,
//                    Discount: null,
//                    ImageURL: imagePaths,
//                    Status: 1,
//                };

//                optionsData.push(option);
//            }
//        }
//        return optionsData;
//    }
//    const addColorButton = document.getElementById('addColorButton');
//    addColorButton.addEventListener('click', function () {
//        addColor();
//    });

//    const addSizeButton = document.getElementById('addSizeButton');
//    addSizeButton.addEventListener('click', function () {
//        addSize();
//    });

//    function guid() {
//        return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
//            var r = Math.random() * 16 | 0,
//                v = c === 'x' ? r : (r & 0x3 | 0x8);
//            return v.toString(16);
//        });
//    }
//});
document.addEventListener('DOMContentLoaded', function () {
    const productForm = document.getElementById('productForm');
    productForm.addEventListener('submit', function (event) {
        event.preventDefault();
    });

    const btnSave = document.getElementById('btn_saveproductdetails');
    btnSave.addEventListener('click', async function () {
        var product_product = document.getElementById("product_name").value;
        var product_category = document.getElementById("category_name").value;
        var product_manufacture = document.getElementById("manufacture_name").value;
        var product_material = document.getElementById("material_name").value;
        var select_brand = document.getElementById("brand_name").value;
        var product_style = document.getElementById("product_style").value;
        var product_origin = document.getElementById("product_origin").value;
        var product_description = document.getElementById("product_description").value;
        var product_images = document.getElementById("image-upload").files;

        if (!product_product || !product_category || !product_manufacture || !product_material || !select_brand || !product_style || !product_origin || !product_description) {
            Swal.fire({
                icon: 'error',
                title: 'Lỗi',
                text: 'Vui lòng điền đầy đủ tất cả các trường thông tin!',
            });
            return;
        }

        try {
            // Lưu sản phẩm
            const productId = await saveProduct({
                CreateBy: "John Doe",
                ID: guid(),
                ProductName: product_product,
                CategoryName: product_category,
                ManufacturersName: product_manufacture,
                MaterialName: product_material,
                BrandName: select_brand,
                Style: product_style,
                Origin: product_origin,
                Description: product_description,
                ImagePaths: [], // Chưa có đường dẫn hình ảnh, sẽ cập nhật sau
                OptionsCreateVM: createOptionsData(),
            });

            // Tải lên ảnh
            await uploadImages(productId.ID, product_images);
            console.log(productId.ID)
            // Thông báo thành công
            Swal.fire({
                icon: 'success',
                title: 'Thành công',
                text: 'Sản phẩm và ảnh đã được lưu thành công!'
            });
        } catch (error) {
            console.error('Đã xảy ra lỗi:', error);
            Swal.fire({
                icon: 'error',
                title: 'Lỗi',
                text: 'Đã xảy ra lỗi trong quá trình lưu sản phẩm hoặc tải ảnh!'
            });
        }
    });

    async function saveProduct(productData) {
        return new Promise((resolve, reject) => {
            var xhr = new XMLHttpRequest();
            var url = 'https://localhost:7241/api/ProductDetails/productdetails_create';
            xhr.open('POST', url, true);
            xhr.setRequestHeader('Content-Type', 'application/json');
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4) {
                    if (xhr.status === 200) {
                        var response = JSON.parse(xhr.responseText);
                        console.log('Đã lưu sản phẩm thành công:', response);
                        console.log(productData);
                        resolve(response.ID);
                    } else {
                        reject(xhr.responseText || 'Lỗi khi lưu sản phẩm');
                    }
                }
            };
            xhr.onerror = function () {
                reject('Lỗi khi gửi yêu cầu lưu sản phẩm');
            };
            xhr.send(JSON.stringify(productData));
        });
    }

    async function uploadImages(productId, product_images) {
        if (product_images.length === 0) {
            console.error('Không có tệp nào để tải lên.');
            return;
        }

        const maxFileSize = 2 * 1024 * 1024; 
        const formData = new FormData();
        for (let i = 0; i < product_images.length; i++) {
            const file = product_images[i];
            if (file.size > maxFileSize) {
                Swal.fire({
                    icon: 'error',
                    title: 'Tệp quá lớn',
                    text: `Kích thước tệp ${file.name} vượt quá giới hạn 2MB.`
                });
                return;
            }
            formData.append('Path', file);
        }

        formData.append('IDProductDetails', productId);
        formData.append('CreateBy', 'John Doe');
        formData.append('Status', 1);

        console.log(productId)

        return new Promise((resolve, reject) => {
            var xhr = new XMLHttpRequest();
            xhr.open('POST', 'https://localhost:7241/api/images/upload_images', true);
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4) {
                    if (xhr.status === 200) {
                        console.log('Ảnh đã được tải lên thành công');
                        resolve();
                    } else {
                        reject(xhr.responseText || 'Lỗi khi tải lên ảnh');
                    }
                }
            };
            xhr.onerror = function () {
                reject('Lỗi khi gửi yêu cầu tải lên ảnh');
            };
            xhr.send(formData);
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
                const imagePaths = cells[0].querySelector('img')?.src || '';

                const option = {
                    ID: guid(),
                    CreateBy: "John Doe",
                    ColorName: color,
                    SizesName: size,
                    StockQuantity: parseInt(soLuong) || 0,
                    CostPrice: parseFloat(giaNhap) || 0,
                    RetailPrice: parseFloat(giaBan) || 0,
                    Discount: null,
                    ImageURL: imagePaths,
                    Status: 1,
                };

                optionsData.push(option);
            }
        }
        return optionsData;
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
            const imageUploadId = `image-upload-${color}-${size}`;
            row.innerHTML = `
                <td class="image-preview-options" id="${imagePreviewId}">
                    <input type="file" id="${imageUploadId}" class="custom-file-input">
                </td>
                <td>${color}</td>
                <td>${size}</td>
                <td><input type="text" placeholder="Nhập giá nhập"></td>
                <td><input type="text" placeholder="Nhập giá bán"></td>
                <td><input type="text" placeholder="0"></td>
                <td><button class="remove-button" onclick="removeRow(this)">Xóa</button></td>
            `;
            tableBody.appendChild(row);

            const fileInput = document.getElementById(imageUploadId);
            fileInput.addEventListener('change', function (event) {
                handleImageUpload(event, imagePreviewId);
            });
        });
    });
}
function handleImageUpload(event, imagePreviewId) {
    const file = event.target.files[0]; // Get the selected file

    if (!file) return;

    const imagePreviewElement = document.getElementById(imagePreviewId);

    // Remove any existing preview
    while (imagePreviewElement.firstChild) {
        imagePreviewElement.removeChild(imagePreviewElement.firstChild);
    }

    const imgElement = document.createElement('img');
    imgElement.style.maxWidth = '100%';
    imgElement.style.maxHeight = '100%';

    const reader = new FileReader();
    reader.onload = function (e) {
        imgElement.src = e.target.result;
    };
    reader.readAsDataURL(file);

    imagePreviewElement.appendChild(imgElement);
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


    loadData("https://localhost:7241/api/Material/GetAllActive", 'product_material', '-- Chọn chất liệu --');
    addChangeListener('product_material', 'material_name');

    loadData("https://localhost:7241/api/Brand/GetAllActive", 'product_brand', '-- Chọn thương hiệu --');
    addChangeListener('product_brand', 'brand_name');

    loadData("https://localhost:7241/api/Manufacturer/GetAllActive", 'product_manufacture', '-- Chọn nhà sản xuất --');
    addChangeListener('product_manufacture', 'manufacture_name');

    loadData("https://localhost:7241/api/Category/GetAllActive", 'product_category', '-- Chọn danh mục --');
    addChangeListener('product_category', 'category_name');
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


