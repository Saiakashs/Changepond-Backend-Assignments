import React, { useState } from 'react';
import { POST } from '../service/HTTP.Service';  
import { useNavigate } from 'react-router-dom';

const Create = () => {
  const navigate=useNavigate();
  const [reservation, setReservation] = useState({
    Name: '',
    StartLocation: '',
    EndLocation: '',
  });

  const handleChange = (e) => {
    setReservation({
      ...reservation,[e.target.name]: e.target.value,
    });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    POST('/api/reservation', reservation)
      .then((createdReservation) => {
        // Check if the created reservation already exists in the list
        const exists = reservation.some((r) => 
          r.Name === createdReservation.Name && 
          r.StartLocation === createdReservation.StartLocation && 
          r.EndLocation === createdReservation.EndLocation
        );
        
        if (!exists) {
          setReservation([...reservation, createdReservation]); // Add reservation if it doesn't already exist
        }
        navigate('/'); // Navigate back to the list
      })
      .catch((error) => console.error(error));
  };
  

  return (
    <div>
      <h2>Add a Reservation</h2>
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label>Name:</label>
          <input
            className="form-control"
            name="Name"
            value={reservation.Name}
            onChange={handleChange}
          />
        </div>
        <div className="form-group">
          <label>Start Location:</label>
          <input
            className="form-control"
            name="StartLocation"
            value={reservation.StartLocation}
            onChange={handleChange}
          />
        </div>
        <div className="form-group">
          <label>End Location:</label>
          <input
            className="form-control"
            name="EndLocation"
            value={reservation.EndLocation}
            onChange={handleChange}
          />
        </div>
        <button type="submit" className="btn btn-sm btn-primary">Add Reservation</button>
      </form>
    </div>
  );
};

export default Create;
