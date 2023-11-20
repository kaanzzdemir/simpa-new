document.addEventListener('DOMContentLoaded', function () {
    var dropdownLinks = document.querySelectorAll('.dropdown-link');

    dropdownLinks.forEach(function (link) {
        link.addEventListener('click', function (event) {
            var targetDropdownId = this.getAttribute('data-target');
            var targetDropdown = document.getElementById(targetDropdownId);

            if (targetDropdown) {
                var isOpen = this.classList.contains('open');

                closeAllDropdowns();
                if (!isOpen) {
                    var bootstrapDropdown = new bootstrap.Dropdown(targetDropdown);
                    bootstrapDropdown.show();
                    this.classList.add('open');

                    // İç accordionlardaki click olaylarını engellemek için
                    var innerAccordionLinks = targetDropdown.querySelectorAll('.dropdown-link');
                    innerAccordionLinks.forEach(function(innerLink) {
                        innerLink.addEventListener('click', function(innerEvent) {
                            innerEvent.stopPropagation(); // Olayın yukarı doğru yayılmasını engelle
                        });
                    });

                    var listItemCount = targetDropdown.querySelectorAll('li').length;
                    var dropdownMenuHeight = 50;

                    // Menü açıldığında <li> öğelerinin yüksekliklerini toplayarak maksimum yükseklik belirle
                    var listItemHeights = Array.from(targetDropdown.querySelectorAll('li')).map(function (li) {
                        return li.clientHeight; // veya li.offsetHeight
                    });
                    var dropdownMaxHeight = Math.max(...listItemHeights) + (listItemCount * dropdownMenuHeight) - Math.max(...listItemHeights);
                    dropdownMaxHeight > 250 ?  targetDropdown.style.height = '250px' : targetDropdown.style.height = dropdownMaxHeight + 'px'
                   
                }
            }
        });
    });

    function closeAllDropdowns() {
        var openDropdownLinks = document.querySelectorAll('.dropdown-link.open');
        openDropdownLinks.forEach(function (openLink) {
            openLink.classList.remove('open');
            var openDropdownId = openLink.getAttribute('data-target');
            var openDropdown = document.getElementById(openDropdownId);
            if (openDropdown) {
                openDropdown.style.height = '0'; // Menüyü kapatmadan önce height'i 0 yap
                var openBootstrapDropdown = new bootstrap.Dropdown(openDropdown);
                openBootstrapDropdown.hide();
            }
        });
    }
});


