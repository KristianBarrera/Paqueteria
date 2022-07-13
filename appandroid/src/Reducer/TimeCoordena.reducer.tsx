
import {ActionTimeCoordenatesType} from '../Types/TypeTimeCoordenates';
import {TimeCoordenates} from '../Interfaces/TimeCoordenates';
import {TimeCoordenatesAction} from '../Action/TimeCoordenates/TimeCoordenates.action';



const initialTimeCoordenates:TimeCoordenates={
  Id:0,
  LatOrigen:0, 
  LogOrigen:0,
  LatDestination:0,
  LogDestination:0
}
export function timecoordenadatesReducer(state:TimeCoordenates= initialTimeCoordenates, action:TimeCoordenatesAction):TimeCoordenates{

  switch(action.type){
    case ActionTimeCoordenatesType.SendCoordenates:{
      return{
        ...state,
        LatDestination:action.payload.LatDestination,
        LogDestination:action.payload.LogDestination
      }

    }

    default:
      return state;
  }
}



