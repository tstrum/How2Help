import { createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../features/home/HomePage";
import CatalogPage from "../../features/catalog/Catalog";
import ContactPage from "../../features/contact/ContactPage";
import AboutPage from "../../features/about/AboutPage";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            {path: '', element: <HomePage />},
            {path: 'catalog', element: <CatalogPage />},
            {path: 'about', element: <AboutPage />},
            {path: 'contact', element: <ContactPage />},
        ]
        
    }
])