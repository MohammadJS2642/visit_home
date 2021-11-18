import axios from "axios";

function getData() {
    const apiUrl = "https://localhost:5001/api/Homes";
    axios.get(apiUrl)
        .then(response => {
            console.log(response);
        })
        .catch(error => {
            console.log(error);
        })
}

// interface Entities {
//     url: String;
// }


export { getData };