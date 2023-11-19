$('.slider').slick({
  dots: false,
  infinite: true,
  speed: 500,
  fade: true,
  cssEase: 'linear',
  prevArrow: "<button type='button' class='slick-prev pull-left'><i class='fa fa-angle-left' aria-hidden='true'></i></button>",
  nextArrow: "<button type='button' class='slick-next pull-right'><i class='fa fa-angle-right' aria-hidden='true'></i></button>"
});
$('.product-slider').slick({
  dots: false,
  infinite: true,
  speed: 500,
  arrows: true,
  fade: true,
  cssEase: 'linear',
  autoplaySpeed: 2000,
  autoplay: true,
  prevArrow: "<button type='button' class='slick-prev pull-left text-black'><i class='fa fa-angle-left' aria-hidden='true'></i></button>",
  nextArrow: "<button type='button' class='slick-next pull-right text-black'><i class='fa fa-angle-right' aria-hidden='true'></i></button>"
});




$('.slider-for').slick({
  slidesToShow: 1,
  slidesToScroll: 1,
  arrows: false,
  fade: true,
  infinite: false,
  asNavFor: '.slider-nav'
});
$('.slider-nav').slick({
  accessibility:false,
  slidesToShow:3,
  slidesToScroll: 1,
  asNavFor: '.slider-for',
  dots: true,
  centerMode: false,
  focusOnSelect: true,
  arrows:false,
  infinite:false
});