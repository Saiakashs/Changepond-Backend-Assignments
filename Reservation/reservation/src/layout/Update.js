import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import { GET, PUT } from '../service/HTTP.Service';  
import { useNavigate } from 'react-router-dom';

const Update = () => {
  const navigate=useNavigate();
  const { id } = useParams();  
  const [reservation, setReservation] = useState({
    Id: id,
    Name: '',
    StartLocation: '',
    EndLocation: '',
  });

  useEffect(() => {
    GET(`/api/reservation/${id}`)
      .then((response) => setReservation(response))
      .catch((error) => console.error(error));
  }, [id]);

  const handleChange = (e) => {
    setReservation({
      ...reservation,
      [e.target.name]: e.target.value,
    });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    PUT('api/reservation', reservation)
      .then(() => {
        navigate('/')
      })
      .catch((error) => console.error(error));
  };

  return (
    <div>
      <h2>Update Reservation</h2>
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
        <button type="submit" className="btn btn-sm btn-primary">Update Reservation</button>
      </form>
    </div>
  );
};

export default Update;
