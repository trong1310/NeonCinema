$(document).ready(function () {
    slider_carouselInit();
});

function slider_carouselInit() {
    jQuery('.owl-carousel.slider_carousel').owlCarousel({
        dots: false,
        loop: true,
        margin: 10,
        stagePadding: 2,
        autoplay: false,
        nav: true,
        navText: ["<i class='fa-solid fa-chevron-left'></i>", "<i class='fa-solid fa-chevron-right'></i>"],
        autoplayTimeout: 1500,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 2,
            },
            992: {
                items: 5
            }
        }
    });
}
