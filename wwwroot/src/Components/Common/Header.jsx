import React from "react";
import HeaderAppBar from "../HeaderAppBar.jsx";



export default class Header extends React.Component{
    constructor(props){
        super(props);
    }

    render(){
        return(
            <div>
                <HeaderAppBar />
            </div>
        )
    }
}