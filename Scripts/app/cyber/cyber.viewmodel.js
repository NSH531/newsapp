var ViewModel = function () {
    var self = this;
    self.news = ko.observableArray();
    self.total = ko.observable();
    self.error = ko.observable();
    var newsapi = 'https://newsapi.org/v2/everything?q=%D7%A1%D7%99%D7%99%D7%91%D7%A8&apiKey=3d52d9ae14c4462f96f8c449fb9f991c';
    //  top-headlines?country=il

    function getAllBooks() {

        $.getJSON(newsapi,

            function (JsonData) {
                // debugger;
                var news = JsonData;
                self.total(JsonData.totalResults);

                self.news(JsonData.articles);

            });


    }

    // Fetch the initial data.
    getAllBooks();
};
ko.applyBindings(new ViewModel(), document.body);