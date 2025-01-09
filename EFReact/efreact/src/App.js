import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import CreateProduct from './components/CreateProduct'; // adjust path if necessary
import EditProduct from './components/EditProduct'; // adjust path if necessary

const App = () => {
    return (
        <Router>
            <Routes>
                <Route path="/create" element={<CreateProduct />} />
                <Route path="/edit/:id" element={<EditProduct />} />
                {/* Add more routes as needed */}
            </Routes>
        </Router>
    );
}

export default App;