/**
 * 配置编译环境和线上环境之间的切换
 * 
 * baseUrl: 域名地址
 * routerMode: 路由模式
 * imgBaseUrl: 图片所在域名地址
 * 
 */

let baseUrl = ''; 
let routerMode = 'hash';
let imgBaseUrl = '';


if (process.env.NODE_ENV == 'development') {
	imgBaseUrl = '';
	baseUrl = 'http://202.98.201.114:7300/mock/5def47767e23140017338c5b';

}else if(process.env.NODE_ENV == 'production'){
	baseUrl = '//elm.cangdu.org';
    imgBaseUrl = '//elm.cangdu.org/img/';
}

export {
	baseUrl,
	routerMode,
	imgBaseUrl,
}