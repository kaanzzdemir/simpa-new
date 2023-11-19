$("a[data-bs-toggle='dropdown'],.dropdown-menu").on({
    mouseenter: function () {
        $(".dropdown-menu").addClass("show");
        $(".nav-link i").css("transform", "rotate(90deg)");
    },
    mouseleave: function () {
        $(".dropdown-menu").removeClass("show");
        $(".nav-link i").css("transform", "rotate(0)");
    }
});