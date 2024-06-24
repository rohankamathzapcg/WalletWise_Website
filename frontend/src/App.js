import React from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import "remixicon/fonts/remixicon.css";
import "bootstrap-icons/font/bootstrap-icons.css";
import "react-toastify/dist/ReactToastify.css";

import Header from "./Components/Header";
import SideBar from "./Components/SideBar";
import Main from "./Pages/Main";
import Footer from "./Components/Footer";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Transactions from "./Pages/Transactions";
import Analytics from "./Pages/Analytics";
import Login from "./Components/Login";
import Profile from "./Pages/Profile";
const App = () => {
  return (
    <>
      <BrowserRouter>
        <Header />
        <Login />
        <SideBar />
        <Routes>
          <Route path="/" element={<Main />} />
          <Route path="/profile" element={<Profile />} />
          <Route path="/transactions" element={<Transactions />} />
          <Route path="/analytics" element={<Analytics />} />
        </Routes>
        <Footer />
      </BrowserRouter>
    </>
  );
};

export default App;
