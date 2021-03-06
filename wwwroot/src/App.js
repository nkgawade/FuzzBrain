import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Route, Switch } from "react-router-dom";
import Header from "./Components/Common/Header.jsx";
import SignIn from './Components/Login/Login.jsx';
import DashBoard from './Components/DashBoard/DashBoard.jsx';
import QuestionsGrid from './Components/QuestionsGrid.jsx';
import SignUp from './Components/Login/Signup.jsx';

function App() {
  return (
    <div className="App">
    <BrowserRouter>
    <Header />
      <Switch>
        <Route exact path="/"><SignIn /></Route>
        <Route exact path="/Dashboard"><DashBoard /></Route>
        <Route exact path="/Questions"><QuestionsGrid /></Route>
        <Route exact path="/Signup"><SignUp /></Route>
      </Switch>
    </BrowserRouter>
    </div>
  );
}

export default App;
