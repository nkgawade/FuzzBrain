import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Grid from '@material-ui/core/Grid';
import QuestionCard from './QuestionCard.jsx';

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
  },
  paper: {
    padding: theme.spacing(2),
    textAlign: 'center',
    color: theme.palette.text.secondary,
  },
}));

export default function QuestionsGrid() {
  const classes = useStyles();

  return (
    <div className={classes.root}>
      <Grid container spacing={4}>
        <Grid item xs>
          <QuestionCard />
        </Grid>
        <Grid item xs>
        <QuestionCard />
        </Grid>
        <Grid item xs>
        <QuestionCard />
        </Grid>
        <Grid item xs>
        <QuestionCard />
        </Grid>
      </Grid>
      <Grid container spacing={4}>
        <Grid item xs>
          <QuestionCard />
        </Grid>
        <Grid item xs>
        <QuestionCard />
        </Grid>
        <Grid item xs>
        <QuestionCard />
        </Grid>
        <Grid item xs>
        <QuestionCard />
        </Grid>
      </Grid>
    </div>
  );
}
