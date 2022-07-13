import {combineReducers} from 'redux';
import {timecoordenadatesReducer} from './TimeCoordena.reducer';

export const reducers = combineReducers({
  timecoordenates:timecoordenadatesReducer
});

export type RootState= ReturnType<typeof reducers>

