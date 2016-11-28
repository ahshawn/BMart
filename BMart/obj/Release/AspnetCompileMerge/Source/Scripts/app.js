var ViewModel = function () {
    var self = this;
    self.products = ko.observableArray();
    self.error = ko.observable();

    //************  Remember to change the URI accordingly  **********************//
    var productsURI = 'http://localhost:60766/api/products/';

    //** this section contains all the AJAX call to the Web APIs **//
    // function to retrieve all products using AJAX call to web API
    function getAllProducts() {
        $.ajax({
            type: 'GET',
            url: productsURI,
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                self.products(data);
            },
            error: function (err) {
                alert("Error: " + err.status + " " + err.statusText);
            }
        });
    };
    // end of function to retrieve all products
    //** this is the end of the section contains all the AJAX call to the Web APIs **//

    // Fetch the initial data
    getAllProducts();
};

ko.applyBindings(new ViewModel());
