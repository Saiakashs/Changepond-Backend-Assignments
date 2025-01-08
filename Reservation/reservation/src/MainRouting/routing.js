import {createBrowserRouter} from "react-router-dom";
import Index from "../layout/Index";
import Create from "../layout/Create";
import Update from "../layout/Update";

const routing=createBrowserRouter([
    {path:"",element:<Index/>},
    {path:"Create",element:<Create/>},
    {path:"Update",element:<Update/>}
])

export default routing;