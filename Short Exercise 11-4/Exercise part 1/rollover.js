$(document).ready(function() {
    $(".hidden").hide();
    $("h2").hover(
        function() {
            $(this).next().show();
        },
        function() {
            $(this).next().hide();
        });





}); // end ready