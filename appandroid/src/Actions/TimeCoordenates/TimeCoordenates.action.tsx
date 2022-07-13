import {TimeCoordenates} from '../../Interfaces/TimeCoordenates';


export enum ActionTimeCoordenatesType{
  SendCoordenates='SendCoordenates',
  ErrorSend='ErrorSend'
}


export interface SendCoordenates{
  type:ActionTimeCoordenatesType.SendCoordenates,
  payload:TimeCoordenates
}

export interface Error{
  type:ActionTimeCoordenatesType.ErrorSend
  payload:TimeCoordenates
}

export type TimeCoordenatesAction = SendCoordenates | Error;