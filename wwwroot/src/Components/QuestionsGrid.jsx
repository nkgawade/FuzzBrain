import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
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
            <Grid container spacing={3}>
                <Grid item xs={12}>
                    <QuestionCard />
                </Grid>
                <Grid item xs={6}>
                    <QuestionCard />
                </Grid>
                <Grid item xs={6}>
                    <QuestionCard />
                </Grid>
                <Grid item xs={3}>
                    <QuestionCard />
                </Grid>
                <Grid item xs={3}>
                    <QuestionCard />
                </Grid>
                <Grid item xs={3}>
                    <QuestionCard />
                </Grid>
                <Grid item xs={3}>
                    <QuestionCard />
                </Grid>
            </Grid>
        </div>
    );
}
