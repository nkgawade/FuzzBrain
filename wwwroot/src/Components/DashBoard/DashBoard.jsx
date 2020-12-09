import React from 'react';
import QuestionsGrid from '../QuestionsGrid.jsx';

export default class DashBoard extends React.Component {
  constructor(props){
    super(props);
  }

  render(){
    return(
        <div><QuestionsGrid /></div>
    )
  }
}