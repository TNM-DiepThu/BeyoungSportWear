document.addEventListener('DOMContentLoaded', function () {
    var currentUrl = window.location.href;

    var urlParts = currentUrl.split('/');
    var ID = urlParts[urlParts.length - 1];

    console.log(ID);
    const productForm = document.getElementById('update_formproductdetails');
    productForm.addEventListener('submit', function (event) {
        event.preventDefault();

        var productData = {
            ModifiedBy: 'acb',
            ProductName: document.getElementById('product_name').value,
            CategoryName: document.getElementById('category_name').value,
            ManufacturersName: document.getElementById('manufacture_name').value,
            MaterialName: document.getElementById('material_name').value,
            BrandName: document.getElementById('brand_name').value,
            Style: document.getElementById('product_style').value,
            origin: document.getElementById('product_origin').value,
            Description: document.getElementById('product_description').value,
            ImagePaths: [],
            OptionsUpdateVM: gatherOptionsData(ID)
        };
        const imageUpload = document.getElementById('image-upload');
        productData.ImagePaths = getImagePaths(imageUpload);

        Swal.fire({
            title: 'Đang cập nhật sản phẩm...',
            allowOutsideClick: false,
            onBeforeOpen: () => {
                Swal.showLoading();
            }
        });

        updateProduct(ID, productData);
        console.log(productData);
    });
    function getImagePaths(input) {
        const files = input.files;
        const imagePaths = [];

        for (let i = 0; i < files.length; i++) {
            const file = files[i];
            const objectUrl = URL.createObjectURL(file);
            imagePaths.push(objectUrl); 
        }

        return imagePaths;
    }

    const addColorButton = document.getElementById('addColorButton');
    addColorButton.addEventListener('click', function (event) {
        event.preventDefault();
        addColor();
    });

    const addSizeButton = document.getElementById('addSizeButton');
    addSizeButton.addEventListener('click', function (event) {
        event.preventDefault();
        addSize();
    });

    if (ID) {
        getProductDetailsById(ID);
    } else {
        alert('Không có ID được cung cấp.');
    }
});

function uploadImages(productData) {
    var fileInput = document.getElementById('image-upload');
    var files = fileInput.files;
    var formData = new FormData();
    for (var i = 0; i < files.length; i++) {
        formData.append('Path', files[i]);
    }
    formData.append('IDProductDetails', productData.ID);
    formData.append('ID', guid());
    formData.append('CreateBy', productData.CreateBy);
    formData.append('Status', '1');

    var xhr = new XMLHttpRequest();
    xhr.open('POST', 'https://localhost:7241/api/images/upload_images', true);
    xhr.onload = function () {
        if (xhr.status === 200) {
            var response = JSON.parse(xhr.responseText);
            console.log('Đường dẫn ảnh đã được lưu:', response.imageUrl);
            productData.ImagePaths.push(response.imageUrl);

            saveProduct(productData);
        } else {
            console.error('Lỗi khi gửi yêu cầu:', xhr.statusText);
            Swal.fire({
                icon: 'error',
                title: 'Lỗi',
                text: 'Đã xảy ra lỗi khi gửi yêu cầu lưu ảnh!\n' + xhr.responseText
            });
        }
    };

    xhr.send(formData);
}
function displayProductImages(imagePaths) {
    var imagePreviewContainer = document.querySelector('.image-preview');
    imagePaths.forEach(function (imagePath) {
        var imgElement = document.createElement('img');
        imgElement.src = imagePath;
        imgElement.alt = 'Preview';
        imgElement.style.maxWidth = '150px';

        var labelElement = document.createElement('label');
        labelElement.classList.add('image-preview-item');

        labelElement.appendChild(imgElement);
        imagePreviewContainer.appendChild(labelElement);
    });
}
function getProductDetailsById(ID) {
    var xhr = new XMLHttpRequest();
    xhr.open('GET', `https://localhost:7241/api/ProductDetails/GetByID/${ID}`, true);
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            if (xhr.status === 200) {
                var data = JSON.parse(xhr.responseText);

                document.getElementById('product_name').value = data.productName;
                document.getElementById('category_name').value = data.categoryName;
                document.getElementById('manufacture_name').value = data.manufacturersName;
                document.getElementById('material_name').value = data.materialName;
                document.getElementById('brand_name').value = data.brandName;
                document.getElementById('product_style').value = data.style;
                document.getElementById('product_origin').value = data.origin;
                document.getElementById('product_description').value = data.description;
                displayProductImages(data.imagePaths);
                var optionsTableBody = document.getElementById('oldClassificationBody');
                optionsTableBody.innerHTML = '';
                if (data.options && data.options.length > 0) {
                    data.options.forEach(function (option) {
                        var row = '<tr>' +
                            '<td><img src="' + option.imageURL + '" alt="Hình ảnh" width="100px"></td>' +
                            '<td>' + option.colorName + '</td>' +
                            '<td>' + option.sizesName + '</td>' +
                            '<td>' + option.costPrice + '</td>' +
                            '<td>' + option.retailPrice + '</td>' +
                            '<td>' + option.stockQuantity + '</td>' +
                            '<td><button class="remove-button" onclick="removeRow(this)">Xóa</button></td>' +
                            '</tr>';
                        optionsTableBody.insertAdjacentHTML('beforeend', row);
                    });
                } else {
                    optionsTableBody.innerHTML = '<tr><td class="no-data" colspan="7">Không có dữ liệu</td></tr>';
                }
            } else {
                console.error('Error fetching product details by Id:', xhr.status);
                alert('Đã xảy ra lỗi khi lấy dữ liệu sản phẩm. Vui lòng thử lại sau.');
            }
        }
    };
    xhr.send();
}
function gatherOptionsData(ID) {
    var options = [];

    var oldTableRows = document.getElementById('oldClassificationBody').getElementsByTagName('tr');
    for (var i = 0; i < oldTableRows.length; i++) {
        var row = oldTableRows[i];
        var cells = row.getElementsByTagName('td');

        if (cells.length < 6) {
            continue;
        }

        var color = cells[1].textContent.trim();
        var size = cells[2].textContent.trim();
        var costPriceFormatted = cells[3].textContent.trim();
        var retailPriceFormatted = cells[4].textContent.trim();
        var stockQuantity = cells[5].textContent.trim();
        var imageURL = cells[0].querySelector('img') ? cells[0].querySelector('img').src : '';

        var costPrice = parseFloat(costPriceFormatted.replace(/[,.đ]/g, ''));
        var retailPrice = parseFloat(retailPriceFormatted.replace(/[,.đ]/g, ''));
        var option = {
            IDProductDetails: ID,
            ColorName: color,
            SizesName: size,
            CostPrice: costPrice,
            RetailPrice: retailPrice,
            Status: 1,
            StockQuantity: parseInt(stockQuantity.replace(/[,.đ]/g, ''), 10),
            ModifiedBy: 'acb',
            Discount: 0,
            ImageURL: imageURL
        };
        options.push(option);
    }

    var newTableBody = document.getElementById('classificationBody');
    var newTableRows = newTableBody.getElementsByTagName('tr');

    if (newTableRows.length === 1 && newTableRows[0].classList.contains('no-data')) {
        return options;
    }

    for (var j = 0; j < newTableRows.length; j++) {
        var newRow = newTableRows[j];
        var cells = newRow.getElementsByTagName('td');

        if (cells.length < 6) {
            continue;
        }

        var newColor = cells[1].textContent.trim();
        var newSize = cells[2].textContent.trim();
        var newCostPriceFormatted = cells[3].getElementsByTagName('input')[0].value.trim();
        var newRetailPriceFormatted = cells[4].getElementsByTagName('input')[0].value.trim();
        var newStockQuantity = cells[5].getElementsByTagName('input')[0].value.trim();
        var newImageURL = cells[0].querySelector('img') ? cells[0].querySelector('img').src : '';

        var newCostPrice = parseFloat(newCostPriceFormatted.replace(/[,.đ]/g, ''));
        var newRetailPrice = parseFloat(newRetailPriceFormatted.replace(/[,.đ]/g, ''));
        var newOption = {
            IDProductDetails: ID,
            ColorName: newColor,
            SizesName: newSize,
            CostPrice: newCostPrice,
            RetailPrice: newRetailPrice,
            StockQuantity: parseInt(newStockQuantity.replace(/[,.đ]/g, ''), 10),
            ModifiedBy: '',
            ImageURL: newImageURL,
            Status: 1,
            Discount: 0
        };
        options.push(newOption);
    }

    return options;
}

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
                <td><input id="giaNhap" type="text" oninput="validateNumberInput(this)" placeholder="Nhập giá nhập"></td>
                <td><input id="giaBan" type="text" oninput="validateNumberInput(this)" placeholder="Nhập giá bán"></td>
                <td><input id="soLuong" type="text" placeholder="0"></td>
                <td><button class="remove-button" onclick="removeRow(this)">Xóa</button></td>
            `;
            tableBody.appendChild(row);

            const fileInput = row.querySelector(`#image-upload-${imagePreviewId}`);
            fileInput.addEventListener('change', function (event) {
                handleImageUpload(event, imagePreviewId);
            });
        });
    });
}
function updateProduct(ID, productData) {
    var xhr = new XMLHttpRequest();
    xhr.open('PUT', `https://localhost:7241/api/ProductDetails/Update/${ID}`, true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            Swal.close();
            if (xhr.status === 200) {
                try {
                    var response;
                    if (xhr.responseText.trim() !== '') {
                        response = JSON.parse(xhr.responseText);
                        console.log('Đã lưu sản phẩm thành công:', response);
                    } else {
                        console.error('Empty response from server');
                        Swal.fire({
                            icon: 'error',
                            title: 'Lỗi!',
                            text: 'Dữ liệu phản hồi từ máy chủ không hợp lệ.'
                        });
                        return;
                    }

                    Swal.fire({
                        icon: 'success',
                        title: 'Thành công!',
                        text: 'Đã cập nhật sản phẩm thành công.',
                        showConfirmButton: false,
                        timer: 3000  
                    }).then(() => {
                        window.location.href = '/home/index_productdetails';
                    });

                } catch (error) {
                    console.error('Error parsing JSON response:', error);
                    Swal.fire({
                        icon: 'error',
                        title: 'Lỗi!',
                        text: 'Dữ liệu phản hồi từ máy chủ không hợp lệ.'
                    });
                }
            } else {
                console.error('Error updating product:', xhr.responseText);
                Swal.fire({
                    icon: 'error',
                    title: 'Lỗi!',
                    text: 'Đã xảy ra lỗi khi cập nhật sản phẩm. Vui lòng thử lại sau.'
                });
            }
        }
    };

    try {
        xhr.send(JSON.stringify(productData));
    } catch (error) {
        console.error('Error sending request:', error);
        Swal.fire({
            icon: 'error',
            title: 'Lỗi!',
            text: 'Đã xảy ra lỗi khi gửi yêu cầu cập nhật sản phẩm.'
        });
    }
}
function handleImageUpload(event, imagePreviewId) {
    const file = event.target.files[0];

    if (!file) return;

    const imagePreviewElement = document.getElementById(imagePreviewId);

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

    loadData("https://localhost:7241/api/Product/GetAllActive", 'product_product', '-- Chọn sản phẩm --');
    addChangeListener('product_product', 'product_name');

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
function validateNumberInput(input) {
    input.value = input.value.replace(/[^\d.-]/g, '');

    let dotCount = input.value.split('.').length - 1;
    if (dotCount > 1) {
        input.value = input.value.slice(0, input.value.lastIndexOf('.'));
    }

    input.value = formatCurrency(input.value);
}
function formatCurrency(amount) {
    return amount.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + " đ";
}
