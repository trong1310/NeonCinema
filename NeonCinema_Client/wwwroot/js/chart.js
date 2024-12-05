// Khởi tạo biến biểu đồ toàn cục
let revenueChartInstance = null;
let movieChartInstance = null;
let comboChartInstance = null;

// Hàm vẽ biểu đồ doanh thu tổng theo ngày
function renderRevenueChart(revenueData) {
    if (!revenueData || revenueData.length === 0) {
        console.error("Không có dữ liệu doanh thu.");
        return;
    }

    const ctx = document.getElementById('revenueChart').getContext('2d');

    if (revenueChartInstance) {
        revenueChartInstance.destroy();
    }

    const labels = revenueData.map(item => new Date(item.date).toLocaleDateString('vi-VN'));
    const data = revenueData.map(item => item.revenue);

    revenueChartInstance = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'Doanh thu (VNĐ)',
                data: data,
                borderColor: 'rgba(0, 123, 255, 1)',
                backgroundColor: 'rgba(0, 123, 255, 0.1)',
                fill: true,
                tension: 0.3,
                pointBackgroundColor: 'rgba(0, 123, 255, 1)',
                pointRadius: 3
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: true,
            aspectRatio: 2,
            plugins: {
                legend: { display: true, position: 'top' }
            },
            scales: {
                x: { title: { display: true, text: 'Ngày' } },
                y: { title: { display: true, text: 'Doanh thu (VNĐ)' }, beginAtZero: true }
            },
            animation: {
                duration: 1000,
                easing: 'easeOutBounce'
            }
        }
    });
}

// Hàm vẽ biểu đồ doanh thu theo phim
function renderMovieChart(movieData) {
    if (!movieData || movieData.length === 0) {
        console.error("Không có dữ liệu phim.");
        return;
    }

    const ctx = document.getElementById('movieChart').getContext('2d');

    if (movieChartInstance) {
        movieChartInstance.destroy();
    }

    const labels = movieData.map(item => item.movieName);
    const data = movieData.map(item => item.revenue);

    movieChartInstance = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: 'Doanh thu phim (VNĐ)',
                data: data,
                backgroundColor: 'rgba(54, 162, 235, 0.6)',
                borderColor: 'rgba(54, 162, 235, 1)',
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: true,
            aspectRatio: 2.5,
            plugins: {
                legend: { display: true, position: 'top' }
            },
            scales: {
                x: { title: { display: true, text: 'Tên phim' } },
                y: { title: { display: true, text: 'Doanh thu (VNĐ)' }, beginAtZero: true }
            },
            animation: {
                duration: 1000,
                easing: 'easeOutQuad'
            }
        }
    });
}

function renderComboChart(comboData) {
    if (!comboData || comboData.length === 0) {
        console.error("Không có dữ liệu combo.");
        return;
    }

    const ctx = document.getElementById('comboChart').getContext('2d');

    // Hủy biểu đồ cũ nếu tồn tại
    if (comboChartInstance) {
        comboChartInstance.destroy();
    }

    const labels = comboData.map(item => item.comboName);
    const data = comboData.map(item => item.quantitySold);

    comboChartInstance = new Chart(ctx, {
        type: 'pie',
        data: {
            labels: labels,
            datasets: [{
                label: 'Số lượng bán',
                data: data,
                backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56', '#4BC0C0', '#9966FF', '#FF9F40'],
                hoverOffset: 8
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: true, // Giữ nguyên tỷ lệ khung hình
            aspectRatio: 1.5, // Điều chỉnh tỷ lệ phù hợp để biểu đồ không quá lớn
            plugins: {
                legend: { display: true, position: 'top' }
            },
            animation: {
                duration: 1000,
                easing: 'easeOutElastic'
            }
        }
    });
}

