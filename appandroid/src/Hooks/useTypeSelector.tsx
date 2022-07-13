import {useSelector,TypedUseSelectorHook} from 'react-redux';
import {RootState} from '../Reducer/combineReducer';
export const useTypedSelector: TypedUseSelectorHook<RootState> = useSelector;