var span = document.getElementsByClassName("close")[0];

showModal = function(rating){
    var modal = documentElementById("editModal");
    documentElementById("updateRating").value = rating;
    modal.style.display = "block";

    var span = document.getElementsByClassName("close")[0];
}

closeModal = function(){
    var modal = documentElementById("editModal");
    modal.style.display = "none";
}

window.onclick = function(event) {
    var modal = documentElementById("editModal");
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

function putDriver(id){
    const putDriverApiUrl = 'https://localhost:7265/api/driver/' +id;
    const driverRating = documentElementById("updateRating").value;

    fetch(putDriverApiUrl, {
        method: 'PUT',
        headers: {
            "Accept": "application/json",
            "Content-Type": "application/json"
        },
        body: JSON.stringify({
            id: id,
            rating: driverRating
        })
    }).then((response)=>{
        console.log(response);
        getDrivers();
    })
}