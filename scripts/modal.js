var recordId = 0;
// Get the modal
var modal = document.getElementById('deleteModal');

// Get the button that opens the modal
var btn = document.getElementById("deleteBtn");

// Get the <span> element that closes the modal
var span = document.getElementById("cancelBtn");
// When the user clicks on the button, open the modal 
function ClickMe(id) {
    recordId = id;
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

function deleteRecordJS() {
    $.ajax({
        url: '~/Home/deleteRecord/',
        data: { id: recordId }
    }).done(function () {
        alert(recordId);
        alert('Deleted');
    });
}