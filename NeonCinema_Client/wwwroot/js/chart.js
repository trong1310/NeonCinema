let chartInstance = null;

function renderRevenueChart(revenueData) {
    if (!revenueData || revenueData.length === 0) {
        console.error("Không có dữ liệu doanh thu.");
        return;
    }

    const ctx = document.getElementById('revenueChart').getContext('2d');

    // Hủy biểu đồ cũ nếu tồn tại
    if (chartInstance) {
        chartInstance.destroy();
    }

    const labels = revenueData.map(item => new Date(item.date).toLocaleDateString('vi-VN'));
    const data = revenueData.map(item => item.revenue);

    chartInstance = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'Doanh thu (VNĐ)',
                data: data,
                borderColor: 'blue',
                fill: false,
                tension: 0.1
            }]
        },
        options: {
            responsive: true,
            scales: {
                x: { title: { display: true, text: 'Ngày' } },
                y: { title: { display: true, text: 'Doanh thu (VNĐ)' } }
            }
        }
    });
}
let movieChartInstance = null;
let comboChartInstance = null;

// Biểu đồ phim
function renderMovieChart(movieData) {
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
            scales: {
                x: { title: { display: true, text: 'Tên phim' } },
                y: { title: { display: true, text: 'Doanh thu (VNĐ)' } }
            }
        }
    });
}

// Biểu đồ combo
function renderComboChart(comboData) {
    const ctx = document.getElementById('comboChart').getContext('2d');

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
                backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56', '#4BC0C0', '#9966FF'],
                hoverOffset: 4
            }]
        },
        options: {
            responsive: true
        }
    });
}
