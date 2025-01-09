import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
// import '../node_modules/bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/css/bootstrap.min.css'

import routing from "./routing"
import { Route, RouterProvider } from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css'

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <RouterProvider router={routing}/>
  </React.StrictMode>
);