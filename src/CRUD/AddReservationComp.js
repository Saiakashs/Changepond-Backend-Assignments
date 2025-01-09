import axios from 'axios';
import React, { useState } from 'react'
import { useNavigate } from 'react-router-dom';

function AddReservationComp() {
    const nav = useNavigate();
    const[url, setUrl] = useState("http://localhost:5048/api/Reservation");

    const [reservation, setreservation] = useState({
            id:"",
            name:"",
            startLocation:"",
            endLocation:"",
        })

    const handleChange =(event)=> {
        const {name, type, value} = event.target;
        setreservation({...reservation, [name]:value});
    }

    const submitData = (event) => {
        event.preventDefault();
        
        axios.post(url, reservation).then(()=>{
            window.alert("Added Successfully");
            nav("/");
        }).catch((error)=>{});
    }



    return (
        <div>
            {/* <h2>This is ProductAddComp</h2> */}

            <div className='row'>
                <div className='col-sm-3'></div>
                <div className='col-sm-6'>
                    <form onSubmit={submitData}>
                    <div className='p-2'>
                            <label>Id </label>
                            <input type="text" className="form-control" name='id' value={reservation.id} onChange={handleChange}></input>
                        </div>

                        <div className='p-2'>
                            <label>Name  </label>
                            <input type="text" className="form-control" name="name" value={reservation.name} onChange={handleChange}></input>
                        </div>

                        <div className='p-2'>
                            <label>Start Location </label>
                            <input type="text" className="form-control" name='startLocation' value={reservation.startLocation} onChange={handleChange}></input>
                        </div>

                        <div className='p-2'>
                            <label>End Location </label>
                            <input type="text" className="form-control" name='endLocation' value={reservation.endLocation} onChange={handleChange} ></input>
                        </div>

                        <button type='submit'>Submit</button>
                    </form>
                </div>
                <div className='col-sm-3'></div>
            </div>
            
        </div>
    )
}

export default AddReservationComp;
