import { createBrowserRouter } from "react-router-dom";
import ReservationDashComp from "./CRUD/ReservationDashComp";
import AddReservationComp from "./CRUD/AddReservationComp";
import EditReservationComp from "./CRUD/EditReservationComp";
import MainDashBoard from "./Layout/MainDashBoard";
import PageNotfound from "./Layout/PageNotFoundComp";


const routing = createBrowserRouter([
    {
        path: "", element: <MainDashBoard />, children: [
            { path: "", element: <ReservationDashComp /> },
            { path: "addreservation", element: <AddReservationComp /> },
            { path: "editreservation/:id", element: <EditReservationComp /> },
            { path: "*", element: <PageNotfound /> },
        ]
    }
]);

export default routing;