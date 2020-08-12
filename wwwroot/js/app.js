window.toggleClass = () => {
    var element = document.getElementById("main-body");
    element.classList.toggle("bg-gray-900");
    element.classList.toggle("text-gray-100");

    var query = document.getElementById("searchQuery");
    var btn = document.getElementById("searchBtn");

    query.classList.toggle("text-gray-800")
    btn.classList.toggle("bg-gray-700")
    

};