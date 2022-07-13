import {createStore,applyMiddleware,compose} from 'redux';
import thunk from 'redux-thunk';
import {reducers} from '../Reducer/combineReducer';

const middleware = applyMiddleware(thunk);

export const store = createStore(reducers,middleware);