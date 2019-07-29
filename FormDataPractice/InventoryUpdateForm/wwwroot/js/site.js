// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

var inventoryForm = document.getElementById("inventoryUpdateForm");

inventoryForm.addEventListener("submit", interceptFormSubmit);

function interceptFormSubmit(event) {
    event.preventDefault();

    var formData = new FormData(inventoryForm);

    var entries = formData.entries();

    var entriesObject = Object.fromEntries(entries);

    var jsonEntries = JSON.stringify(entriesObject);

    console.log(jsonEntries);

    // for (var pair of formData.entries()) {
    //     console.log(pair[0] + " " + pair[1]);
    // }

    //console.log(formData.entries()[0][0]);
}
