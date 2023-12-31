﻿$(function () {
    $('#expertiseTable').each(function () {
        if ($(this).find('thead').length > 0 && $(this).find('th').length > 0) {
            // Clone <thead>
            var $w = $(window),
                $t = $(this),
                $thead = $t.find('thead').clone(),
                $col = $t.find('thead, tbody').clone();

            // Add class, remove margins, reset width and wrap table
            $t
                .addClass('sticky-enabled')
                .css({
                    margin: 0,
                    width: '100%'
                }).wrap('<div class="sticky-wrap" />');

            if ($t.hasClass('overflow-y')) $t.removeClass('overflow-y').parent().addClass('overflow-y');

            // Create new sticky table head (basic)
            $t.after('<table class="sticky-thead" />');

            var isChrome = !!window.chrome && !!window.chrome.webstore;
            var fireFoxWidth = 0;
            //    if (isChrome) {
            var expertiseWidth = $('#expertiseTable').width();
            if (expertiseWidth >= 1301) {
                $('.sticky-wrap.overflow-y').addClass('overflowFirst');
                $('.sticky-wrap.overflow-y').removeClass('overflowSecond');
                var isFirefox = typeof InstallTrigger !== 'undefined';
                var ua = window.navigator.userAgent;
                var ie = ua.search(/(MSIE|Trident|Edge)/);
                if (ie > -1) {
                    fireFoxWidth = $('#expertiseTable .log-number').width();
                    $('.sticky-thead tr:nth-child(2) th:nth-child(2) #log-num').css('width', fireFoxWidth);
                }
                if (isFirefox) {
                    fireFoxWidth = $('#expertiseTable .log-number').width();
                    $('.sticky-thead tr:nth-child(2) th:nth-child(2) #log-num').css('width', fireFoxWidth);
                }
                if (isChrome) {
                    //       $('.sticky-wrap .sticky-thead').css('width', 'auto');
                    fireFoxWidth = $('#expertiseTable .log-number').width();

                    $('.sticky-thead tr:nth-child(2) th:nth-child(2) #log-num').css('width', fireFoxWidth);
                    $('.sticky-thead tr:nth-child(2) th:nth-child(3) #award').css('width', fireFoxWidth);
                }
            } else {
                $('.sticky-wrap.overflow-y').removeClass('overflowFirst');
                $('.sticky-wrap.overflow-y').addClass('overflowSecond');
                //    var isChrome = !!window.chrome && !!window.chrome.webstore;

                if (isChrome) {
                    $('.sticky-wrap .sticky-thead').css('width', 'auto');
                }
            }
            //    }
            // If <tbody> contains <th>, then we create sticky column and intersect (advanced)
            if ($t.find('tbody th').length > 0) {
                $t.after('<table class="sticky-col" /><table class="sticky-intersect" />');
            }

            // Create shorthand for things
            var $stickyHead = $(this).siblings('.sticky-thead'),
                $stickyCol = $(this).siblings('.sticky-col'),
                $stickyInsct = $(this).siblings('.sticky-intersect'),
                $stickyWrap = $(this).parent('.sticky-wrap');

            $stickyHead.append($thead);

            $stickyCol
                .append($col)
                .find('thead th:gt(1)').remove()
                .end()
                .find('tbody td').remove();

            $stickyInsct.html('<thead><tr><th>Assigned:<tr><th id="logID">Log #' + $t.find('thead th:first-child').html() + '</th></tr></th></tr></thead>');
          //  $stickyInsct.html('<thead><tr><th>Assigned:<tr><th id="logID">Log #' + $t.find('thead th:first-child').html() + '</th><th style="word-wrap:break-word;background:#fff" id="awardMechID">Award Mechanism' + $t.find('thead th:first-child').html() + '</th></tr></th></tr></thead>');
 
            // Set widths
            var setWidths = function () {
                $t
                .find('thead th').each(function (i) {
                    $stickyHead.find('th').eq(i).width($(this).width());
                })
                .end()
                .find('tr').each(function (i) {
                    $stickyCol.find('tr').eq(i).height($(this).height());
                });

                // Set width of sticky table head
                $stickyHead.width($t.width());
                // Set width of sticky table col
                $stickyCol.find('th').add($stickyInsct.find('th')).width($t.find('thead th').width());
            },
				repositionStickyHead = function () {
				    // Return value of calculated allowance
				    var allowance = calcAllowance();

				    // Check if wrapper parent is overflowing along the y-axis
				    if ($t.height() > $stickyWrap.height()) {
				        // If it is overflowing (advanced layout)
				        // Position sticky header based on wrapper scrollTop()
				        if ($stickyWrap.scrollTop() > 0) {
				            // When top of wrapping parent is out of view
				            $stickyHead.add($stickyInsct).css({
				                opacity: 1,
				                top: $stickyWrap.scrollTop()
				            });
				        } else {
				            // When top of wrapping parent is in view
				            $stickyHead.add($stickyInsct).css({
				                opacity: 0,
				                top: 0
				            });
				        }
				    } else {
				        // If it is not overflowing (basic layout)
				        // Position sticky header based on viewport scrollTop
				        if ($w.scrollTop() > $t.offset().top && $w.scrollTop() < $t.offset().top + $t.outerHeight() - allowance) {
				            // When top of viewport is in the table itself
				            $stickyHead.add($stickyInsct).css({
				                opacity: 1,
				                top: $w.scrollTop() - $t.offset().top
				            });
				        } else {
				            // When top of viewport is above or below table
				            $stickyHead.add($stickyInsct).css({
				                opacity: 0,
				                top: 0
				            });
				        }
				    }
				},
				repositionStickyCol = function () {
				    if ($stickyWrap.scrollLeft() > 0) {
				        // When left of wrapping parent is out of view
				        $stickyCol.add($stickyInsct).css({
				            opacity: 1,
				            left: $stickyWrap.scrollLeft()
				        });
                        var fireFoxWidth = $('#expertiseTable .log-number').width(); 
                        //$('.sticky-intersect tr').find('th').css('width', fireFoxWidth);
                        $('.sticky-intersect').find('tr:nth-child(2)').find('th').css('width', fireFoxWidth);
				        $('.sticky-wrap .sticky-intersect').show();
				        if ($('#activeCheckbox').is(':checked')) {
				            var eachCell = $('.sticky-col tbody tr th');

				            $(eachCell).each(function (i, value) {
				                var hasClass = $(this).find('.pm-threshold_exclamation');

				                // If both select dropdowns have a value
				                if (hasClass.length <= 0) {
				                    $(this).closest('tr').remove();
				                }
				            })
				        }
				    } else {
				        // When left of wrapping parent is in view
				        $stickyCol
						.css({ opacity: 0 })
						.add($stickyInsct).css({ left: 0 });
				        $('.sticky-intersect tr th').css('width', '0px');
				        $('.sticky-wrap .sticky-intersect').hide();

				    }
				},
				calcAllowance = function () {
				    var a = 0;
				    // Calculate allowance
				    $t.find('tbody tr:lt(3)').each(function () {
				        a += $(this).height();
				    });

				    // Set fail safe limit (last three row might be too tall)
				    // Set arbitrary limit at 0.25 of viewport height, or you can use an arbitrary pixel value
				    if (a > $w.height() * 0.25) {
				        a = $w.height() * 0.25;
				    }

				    // Add the height of sticky header
				    a += $stickyHead.height();
				    return a;
				};

            setWidths();

            $t.parent('.sticky-wrap').scroll($.throttle(0, function () {
                repositionStickyHead();
                repositionStickyCol();
                var isChrome = !!window.chrome && !!window.chrome.webstore;

                if (isChrome) {
                    //$('.sticky-wrap .sticky-thead').css('width', 'auto');
                }
            }));

            $w
			.load(setWidths)
			.resize($.debounce(0, function () {
			    setWidths();
			    repositionStickyHead();
			    repositionStickyCol();
			}))
			.scroll($.throttle(0, repositionStickyHead));

            var expColWidth = $('.sticky-thead tr > .reviewer-name').width();
            var expColHeight = $('.sticky-thead tr > .reviewer-name').height();

            var isChrome = !!window.chrome && !!window.chrome.webstore;
            var isFirefox = typeof InstallTrigger !== 'undefined';
            var ua = window.navigator.userAgent;
            var ie = ua.search(/(MSIE|Trident|Edge)/);

            if (ie > -1) {

            }

            if (isChrome) {
                //$('.sticky-wrap .sticky-thead').css('width', 'auto');
            }
            if (isFirefox) {

            }
            $('#logID').css('height', expColHeight + 'px');
        }
    });
});