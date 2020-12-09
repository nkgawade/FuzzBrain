import React, { Component } from "react";
import axios from 'axios';
import { withRouter } from 'react-router-dom';

class SignUp extends Component {
    constructor(props){
        super(props);
        this.state ={
            UserName : '',
            UserPassword: '',
            UserEmail:''
          }
    }

    onChangeUserEmail = (event) =>{
        this.setState({
            UserEmail: event.target.value
        });
      }

    onChangeName = (event) =>{
        this.setState({
          UserName: event.target.value
        });
      }
    
      onChangePassword = (event) =>{
        this.setState({
          UserPassword: event.target.value
        });
    }


        handleSubmit = (event) => {

            if(this.state.UserName != '' && this.state.UserPassword != '' && this.state.UserEmail != '' ){
             event.preventDefault();
             const model = {
               UserName: this.state.UserEmail,
               UserPassword: this.state.UserPassword
             };
         
             
             axios.post('http://localhost:56855/Acccounts/Signup', { model })
               .then(res => {
                 console.log(res);
                 console.log(res.data);
               })
               this.props.history.push('/');
            }
       
           event.preventDefault();
         };

    render() {
        return (
            <form>
                <h3>Sign Up</h3>

                <div className="form-group">
                    <label>User name</label>
                    <input type="text" value={this.state.UserName} onChange={this.onChangeName} className="form-control" placeholder="User name" />
                </div>

                <div className="form-group">
                    <label>Email address</label>
                    <input type="email" value={this.state.UserEmail} onChange={this.onChangeUserEmail} className="form-control" placeholder="Enter email" />
                </div>

                <div className="form-group">
                    <label>Password</label>
                    <input type="password" value={this.state.UserPassword} onChange={this.onChangePassword} className="form-control" placeholder="Enter password" />
                </div>

                <button type="submit" className="btn btn-primary btn-block" onClick={this.handleSubmit}>Sign Up</button>
                <p className="forgot-password text-right">
                    Already registered <a href="/">sign in?</a>
                </p>
            </form>
        );
    }
}

export default withRouter(SignUp);