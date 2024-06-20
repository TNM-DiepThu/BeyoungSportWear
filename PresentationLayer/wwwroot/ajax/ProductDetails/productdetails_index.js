function displayData(data) {
    const tableBody = document.getElementById('table_productdetails');
    tableBody.innerHTML = '';
    data.forEach(productdetails => {
        const formattedSmallestPrice = productdetails.smallestPrice.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' });
        const formattedBiggestPrice = productdetails.biggestPrice.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' });

        let priceToShow = '';
        if (formattedSmallestPrice !== formattedBiggestPrice) {
            priceToShow = `${formattedSmallestPrice} - ${formattedBiggestPrice}`;
        } else {
            priceToShow = formattedSmallestPrice;
        }

        const row = document.createElement('tr');
        row.innerHTML = `
            <td width="10"><input type="checkbox" name="check1" value="${productdetails.id}"></td>
            <td>${productdetails.keyCode}</td>
            <td>${productdetails.productName}</td>
            <td>
                <img src="${productdetails.imagePaths[0]}" alt="Ảnh sản phẩm" width="100px;">
            </td>
            <td>${productdetails.totalQuantity}</td>
            <td>
                ${productdetails.totalQuantity >= 1 ? '<span class="badge bg-success">Còn hàng</span>' : '<span class="badge bg-danger">Hết hàng</span>'}
            </td>
            <td>${priceToShow}</td>
            <td>${productdetails.categoryName}</td>
            <td>
                <button class="btn btn-primary btn-sm trash" type="button" title="Xóa" onclick="confirmDelete('${productdetails.id}', 'userID')">
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
function confirmDelete(productID, userID) {
    Swal.fire({
        title: 'Bạn có chắc chắn muốn xóa sản phẩm này?',
        text: "Hành động này không thể hoàn tác!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Có, xóa nó!',
        cancelButtonText: 'Hủy bỏ'
    }).then((result) => {
        if (result.isConfirmed) {
            deleteProduct(productID, userID);
        }
    });
}
function deleteProduct(productID, userID) {
    var xhr = new XMLHttpRequest();
    xhr.open('DELETE', `https://localhost:7241/api/ProductDetails/${productID}/${userID}`, true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            if (xhr.status === 200) {
                Swal.fire({
                    icon: 'success',
                    title: 'Thành công!',
                    text: 'Đã xóa sản phẩm thành công.',
                    timer: 3000,
                    timerProgressBar: true,
                    willClose: () => {
                        window.location.href = '/home/index_productdetails';
                    }
                });
            } else {
                Swal.fire({
                    icon: 'error',
                    title: 'Lỗi!',
                    text: 'Đã xảy ra lỗi khi xóa sản phẩm. Vui lòng thử lại sau.'
                });
            }
        }
    };

    try {
        console.log(productID)
        console.log(userID)
        xhr.send();

    } catch (error) {
        console.error('Error sending request:', error);
        Swal.fire({
            icon: 'error',
            title: 'Lỗi!',
            text: 'Đã xảy ra lỗi khi gửi yêu cầu xóa sản phẩm.'
        });
    }
}
document.addEventListener('DOMContentLoaded', fetchData);
