import { createBrowserRouter } from "react-router-dom";
import ReservationDashComp from "./CRUD/Reservation";
import AddReservationComp from "./CRUD/AddReservation";
import EditReservationComp from "./CRUD/EditReservation";



const routing = createBrowserRouter([
           
    { path: "", element: <ReservationDashComp /> },
    { path: "addreservation", element: <AddReservationComp /> },
    { path: "editreservation/:id", element: <EditReservationComp /> },
      
])

export default routing;