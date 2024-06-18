function displayData(data) {
    const tableBody = document.getElementById('table_productdetails');
    tableBody.innerHTML = '';
    data.forEach(productdetails => {
        const row = document.createElement('tr');
        row.innerHTML = `
                    <td width="10"><input type="checkbox" name="check1" value="1"></td>
                    <td>${productdetails.keyCode}</td>
                    <td>${productdetails.productName}</td>
                     <td>
                        <img src="${productdetails.imagePaths[0]}" alt="Ảnh sản phẩm" width="100px;">
                    </td>
                    <td>${productdetails.totalQuantity}</td>
                        <td>
                            ${productdetails.totalQuantity >= 1 ? '<span class="badge bg-success">Còn hàng</span>' : '<span class="badge bg-danger">Hết hàng</span>'}
                        </td>
                    <td>${productdetails.smallestPrice} - ${productdetails.biggestPrice}</td>
                    <td>${productdetails.categoryName}</td>
                    <td>
                        <button class="btn btn-primary btn-sm trash" type="button" title="Xóa" onclick="myFunction(this)">
                            <i class="fas fa-trash-alt"></i>
                        </button>
                        <button class="btn btn-primary btn-sm edit" type="button" title="Sửa" onclick="navigateToUpdatePage('${productdetails.id}')">
                            <i class="fas fa-edit"></i>
                        </button>
                    </td>
                `;
        tableBody.appendChild(row);
    });
    document.getElementById('loading-spinner').style.display = 'none';
}
function fetchData() {
    var xhr = new XMLHttpRequest();
    xhr.open('GET', 'https://localhost:7241/api/ProductDetails/GetAllActive', true);

    document.getElementById('loading-spinner').style.display = 'block';

    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4) {
            if (xhr.status == 200) {
                var data = JSON.parse(xhr.responseText);
                displayData(data);
            } else {
                console.error('Error fetching data:', xhr.statusText);
            }
        }
    };
    xhr.send();
}
function navigateToUpdatePage(productId) {
    window.location.href = `/managerupdate_productdetails/${productId}`;
}

document.addEventListener('DOMContentLoaded', fetchData);