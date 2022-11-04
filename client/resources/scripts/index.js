
function getDrivers(){
    const allDriversApiUrl = 'https://localhost:7265/api/driver';

    fetch(allDriversApiUrl).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        let html = "<table style=\"width:100%\">";
        html += "<tr><th>Id</th><th>Name</th><th>Rating</th><th>DateHired</th><th>Edit</th><th>Delete</th></tr>";
            json.forEach((driver)=>{
                if(driver.deleted != 1){
                    html += "<tr>";
                    html += "<td>" + driver.id + "</td>";
                    html += "<td>" + driver.name + "</td>";
                    html += "<td>" + driver.rating + "</td>";
                    html += "<td>" + driver.dateHired + "</td>";
                    html += "<td><button onclick=\"putDriver(" + driver.id  + ")\">Edit</button><input type=\"text\" id=\"newRating" + driver.id +"\"></td>";
                    html += "<td><button onclick=\"removeDriver(" + driver.id + ")\">Delete</button></td>";
                    html += "</tr>";
                }
            });
        
        html += "</table>";
        document.getElementById("drivers").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    });
}

function postDriver(){
    const postDriverApiUrl = 'https://localhost:7265/api/driver';
    const sendDriver = {
        Name: document.getElementById("name").value,
        Rating: document.getElementById("rating").value,
    }
    
    fetch(postDriverApiUrl, {
        method: 'POST',
        headers: {
            "Accept": "application/json",
            "Content-Type": "application/json"
        },
        body: JSON.stringify(sendDriver)
    }).then((response)=>{
        console.log(response == 200);
        getDrivers();
    })
}

function putDriver(id){
    const putDriverApiUrl = 'https://localhost:7265/api/driver/' + id;
    const updateDriver = {
        Name: '',
        Rating: document.getElementById("newRating" + id).value
    }
    fetch(putDriverApiUrl, {
        method: 'PUT',
        headers: {
            "Accept": "application/json",
            "Content-Type": "application/json"
        },
        body: JSON.stringify(updateDriver)
    }).then((response)=>{
        console.log(response);
        getDrivers();
    })
}

function removeDriver(id){
    const deleteDriverApiUrl = 'https://localhost:7265/api/driver/' + id;
    
    fetch(deleteDriverApiUrl, {
        method: 'DELETE',
        headers: {
            "Accept": "application/json",
            "Content-Type": "application/json"
        },
    }).then((response)=>{
        console.log(response);
        getDrivers();
    })
}