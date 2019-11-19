$(document).ready(function() {
    $("#image_list img").each(function()
    {
        // get the new image url and save the old one
        var imageURL = $(this).attr("id");
        var oldImageURL = $(this).attr("src");

        // preload the image from the link
        var hoverImage = new Image();
        hoverImage.src = imageURL;

        // event handler for hovering and de-hovering
        $(this).hover(function (evt)
        {
            $(this).attr("src", imageURL);
            evt.preventDefault();
        },
        function (evt)
        {
            $(this).attr("src", oldImageURL);
            evt.preventDefault();
        });

        // event handler for adding the user selected items to the order select box on click
        // also updates the total value
        $(this).click(function (evt)
        {
            $("#user_order").append(new Option(
                $(this).attr("data-price") + " - " + $(this).attr("alt"),
                $(this).attr("data-price")));

            var currentPrice = $("#total").text().split("$")[1];
            var newPrice = (parseFloat(currentPrice) + parseFloat($(this).attr("data-price")))
                .toFixed(2);
            $("#total").text("Total: $" + newPrice.toString());
            evt.preventDefault();
        });
    }); // end img event handling

    // empties all options from select box when clear is clicked
    $("#clear").click(function ()
    {
        $("#user_order").empty();
        $("#total").text("Total: $0");
    }); // end clear order click

    // replaces window html location with checkout page when place order is clicked
    $("#place").click(function ()
    {
        window.location.replace("checkout.html");
    }); // end place order click
}); // end ready