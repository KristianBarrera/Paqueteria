import React from 'react'
import routeAxiosRouters from '../Config/AxiosCoordenates';
import {TimeCoordenates} from '../Interfaces/TimeCoordenates';




export const useTimeReal = () => {
  
  
  const sendMessage = async(data:TimeCoordenates)=>{
      try{  
      const respuesta = await routeAxiosRouters.put('v1/coordenates/enviar');
      console.log(respuesta);
      }catch(e:any){
        console.log('Error en Enviar:', e);  
      }
  }

  return {
    sendMessage
  };

}
