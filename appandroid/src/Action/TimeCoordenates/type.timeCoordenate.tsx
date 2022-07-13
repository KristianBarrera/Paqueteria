import {Dispatch} from 'redux';
import {TimeCoordenatesAction} from '../TimeCoordenates/TimeCoordenates.action';
import {TimeCoordenates} from '../../Interfaces/TimeCoordenates';
import routeAxiosRouters from '../../Config/AxiosCoordenates';


// nos falta llamar las configuracion de Axios
export const SendCoorde =(timecoorde:TimeCoordenates)=>{
  return async (dispatch: Dispatch<TimeCoordenatesAction>) => {
    try{
       
        const respuesta = await routeAxiosRouters.put(`/v1/coordenates/enviar`,timecoorde);
        console.log(respuesta.data);
      }
    catch(e:any){
      console.log(e);
    }
  }
}

