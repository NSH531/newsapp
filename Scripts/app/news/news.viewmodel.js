var ViewModel = function () {
    var self = this;
    self.news = ko.observableArray();
    self.total = ko.observable();
    self.error = ko.observable();
    var newsapi = 'https://newsapi.org/v2/top-headlines?country=il&apiKey=3d52d9ae14c4462f96f8c449fb9f991c';
    

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