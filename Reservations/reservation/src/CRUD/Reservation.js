import React, { useEffect, useState } from 'react'
import axios from 'axios';
import { Link, Outlet } from 'react-router-dom';



function ReservationDashComp() {
    const [reservations, setReservations] = useState([]);

    useEffect(() => {
        getData();
    }, [])

    const getData = () => {
        axios.get("http://localhost:5048/api/Reservation").then((res) => {
            console.log(res.data);
            setReservations(res.data);
        }).catch((error) => { })
    }

    const deleteFun = (id) => {
        // window.alert(`Delete button clicked ${id}`);
        let conf = window.confirm("Do you want to Delete it");
        conf && axios.delete(`http://localhost:5048/api/Reservation/${id}`).then(() => {
            getData();
        }).catch((error) => { });
    }

    return (
        <div>
            <h2>Reservations</h2>
            <Link to="addreservation" className='btn btn-primary mt-3 mb-3'>
                Add
            </Link>

            <table className='table table-hover table-bordered table-striped'>

                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Start Location</th>
                        <th>End Location</th>
                        <th>Update</th>
                        <th>Delete</th>
                    </tr>
                </thead>
                <tbody>

                    {
                        reservations.map((val, index) => {
                            return <tr key={val.id}>
                                <td>{val.id}</td>
                                <td>{val.name}</td>
                                <td>{val.startLocation}</td>
                                <td>{val.endLocation}</td>
                                <td>
                                    <Link to={`editreservation/${val.id}`} className='btn btn-outline-success' >
                                        Edit
                                    </Link>
                                </td>
                                <td>

                                    <button type='button' onClick={() => { deleteFun(val.id) }} className='btn btn-outline-danger'>
                                        Delete
                                    </button>
                                </td>
                            </tr>
                        })
                    }

                </tbody>
            </table>
        </div>

        
    )
}

export default ReservationDashComp;