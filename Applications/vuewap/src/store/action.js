import {
	getUser,
	getMovies,
	getMovieDetail,
	getAddressList
} from '../service/getData'
import {
	GET_USERINFO,
	SAVE_ADDRESS
} from './mutation-types.js'

export default {
	async getMovies({
		commit,
		state
	},
	type,
	page,
	pagesize) {
		let res = await getMovies(type,page,pagesize);
		return res.data;
	},
	async getMovieDetail({
		commit,
		state
	},
	id) {
		let res = await getMovieDetail(id);
		return res.data;
	},

	async getUserInfo({
		commit,
		state
	}) {
		let res = await getUser();
		commit(GET_USERINFO, res)
	},
	async saveAddress({
		commit,
		state
	}) {

		if(state.removeAddress.length > 0) return;

		let addres = await getAddressList(state.userInfo.user_id);
		commit(SAVE_ADDRESS, addres);	
	},
}