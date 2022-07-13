import axios from 'axios';
const routeAxiosRouters = axios.create({
  baseURL:'http://192.168.100.106:5229'
});

export default routeAxiosRouters;