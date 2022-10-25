import { React } from 'react';
import Popup from 'reactjs-popup';
import 'reactjs-popup/dist/index.css';
import './../../custom.css';

export default function CreatePopUp() {
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
                                <input id="name" type="text" />
                            </p>
                            <p>
                                <label htmlFor="number">Price :</label>
                                <input id="number" type="number" />
                            </p>
            
                            <button>Submit</button>
                        </form>
                       
                    </div>
                </div>
            )}
        </Popup>
    );
}