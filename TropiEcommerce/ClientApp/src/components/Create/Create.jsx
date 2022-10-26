import { React, useState } from 'react';
import Popup from 'reactjs-popup';
import 'reactjs-popup/dist/index.css';
import './../../custom.css';

export default function CreatePopUp() {
    const [data, setDatos] = useState({
        Name: '',
        Price: 0,
        Photo:''
    })
    const handleInputChange = (event) => {
         console.log(event.target.name)
        
        setDatos({
            ...data,
            [event.target.name]: event.target.value
        })
    }
    const createProduct = (close) => {
        return (event) => {
            event.preventDefault()
            // Using Fetch API
            fetch('product', {
                    method: 'POST',
                    body: JSON.stringify(data),
                    headers: {
                        'Content-type': 'application/json; charset=UTF-8',
                    },
                })
                .then((response) => response.json())
                .then((data) => {
                    console.log(data);
                    close();
                    // Handle data
                })
                .catch((err) => {
                    console.log(err.message);
                });
            close();
        }
    }
    return(
        <Popup trigger={<button> Create </button>} position="right center" modal nested>
            {close =>
            (
                <div className="myModal">
                    <button className="close" onClick={close}> &times; </button>
                    <div className="header"> Create a Product </div>
                    <div className="content">
                        <form>
                            <p>
                                <label htmlFor="text">Name :</label>
                                <input id="name" name="Name" type="text" placeholder="Name" onChange={handleInputChange} />
                            </p>
                            <p>
                                <label htmlFor="number">Price :</label>
                                <input id="number" name="Price" type="number" placeholder="Price" onChange={handleInputChange} />
                            </p>

                            <button onClick={createProduct(close)}>Submit</button>
                        </form>
                       
                    </div>
                </div>
            )}
        </Popup>
    );
}