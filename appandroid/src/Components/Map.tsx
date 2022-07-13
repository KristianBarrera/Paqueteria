import React, { useRef,useEffect, useState } from 'react';
import MapView, { Marker } from 'react-native-maps';
import { useLocation } from '../Hooks/useLocation';
import { LoadingScreen } from '../Screens/LoadingScreen';
import { Fab } from './Fab';
import { TimeCoordenates } from '../Interfaces/TimeCoordenates';
import {useDispatch} from 'react-redux';
import { Dispatch } from "redux"
import {SendCoorde} from '../Action/TimeCoordenates/type.timeCoordenate';



interface Props {
  markers?: Marker[];
}

export const Map = ({ markers }: Props) => {
  const dispatch: Dispatch<any> = useDispatch()
  const { hasLocation, 
          initialPosition, 
          getcurrentLocation,
          followUserLocation,
          userrLocation,
          stopFollowUserLocation,
          routeLines } = useLocation();
  const mapViewRef = useRef<MapView>();
  const following = useRef<boolean>(true);

  
  const [gettiem,settime]= useState<TimeCoordenates>({
    Id:0,
    LatOrigen:0,
    LogOrigen:0,
    LatDestination:0,
    LogDestination:0
  });

  useEffect(()=>{
    followUserLocation();
    return ()=>{
      stopFollowUserLocation();
    }
  },[]);

  useEffect(()=>{

    if(!following.current){
      return;
    }
    const {longitude,latitude}= userrLocation;

    settime({
      Id:1,
      LatOrigen:latitude,
      LogOrigen:longitude,
      LatDestination:0,
      LogDestination:0
    })
    dispatch(
      SendCoorde(gettiem)
    );
    mapViewRef.current?.animateCamera({
      center: {
        latitude: latitude,
        longitude: longitude
      },
      zoom: 20
    });

  },[userrLocation]);



  const centerPosition = async () => {
    const location = await getcurrentLocation();
    following.current =true;

    mapViewRef.current?.animateCamera({
      center: {
        latitude: location.latitude,
        longitude: location.longitude
      },
      zoom: 20
    });
  }

  if (!hasLocation) {
    return <LoadingScreen />
  }

  return (
    <>
      <MapView
        ref={(el) => mapViewRef.current = el!}
        showsUserLocation
        style={{ flex: 1 }}
        initialRegion={{
          latitude: initialPosition.latitude,
          longitude: initialPosition.longitude,
          latitudeDelta: 0.0922,
          longitudeDelta: 0.0421,
        }}
        onTouchStart={()=> following.current = false}
      >
      </MapView>
      <Fab
        iconName='compass-outline'
        onPress={centerPosition}
        style={{
          position: 'absolute',
          bottom: 10,
          right: 10
        }}
      />
    </>
  )
}
