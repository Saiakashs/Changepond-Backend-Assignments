import {createBrowserRouter} from "react-router-dom";
import Index from "../layout/Index";
import Create from "../layout/Create";
import Update from "../layout/Update";

const routing = createBrowserRouter([
    {
        path: "", 
        element: <MainDashBoard />, 
        children: [
            { path: "", element: <ReservationDashComp /> },
            { path: "addreservation", element: <AddReservationComp /> },
            { path: "editreservation/:id", element: <EditReservationComp /> },
            { path: "*", element: <PageNotfound /> },
        ]
    }
]);

export default routing;