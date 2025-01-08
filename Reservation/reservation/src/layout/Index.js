import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { GET,DELETE} from '../service/HTTP.Service';  

const Index = () => {
  const [reservation, setReservation] = useState([]);

  useEffect(() => {
    GET('/api/reservation') 
      .then((response) => {
        setReservation(response); // Set state with fetched data
      })
      .catch((error) => console.error(error));
  }, []);
  
  const deleteReservation = (id) => {
    DELETE(`/api/reservation/${id}`)
      .then(() => {
        // Remove the deleted reservation from the state
        setReservation(reservation.filter((res) => res.Id !== id));
      })
      .catch((error) => console.error(error));
  };
  
  const addReservation = (newRes) => {
    // Check if the reservation already exists in the state
    const exists = reservation.some((r) => 
      r.Name === newRes.Name && r.StartLocation === newRes.StartLocation && r.EndLocation === newRes.EndLocation
    );
  
    if (!exists) {
      setReservation([...reservation, newRes]); // Add new reservation if it doesn't already exist
    }
  };
  

  return (
    <div>
      <h2>All Reservations</h2>
      <Link to="/Create" className="btn btn-sm btn-primary">Add Reservation</Link>
      <table className="table table-sm table-striped table-bordered m-2">
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
          {reservation.map((r) => (
            <tr key={r.Id}>
              <td>{r.Id}</td>
              <td>{r.Name}</td>
              <td>{r.StartLocation}</td>
              <td>{r.EndLocation}</td>
              <td>
                <Link to={`/Update/${r.Id}`} className="btn btn-sm btn-secondary">Edit</Link>
              </td>
              <td>
                <button onClick={() => deleteReservation(r.Id)} className="btn btn-sm btn-danger">Delete</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default Index;
