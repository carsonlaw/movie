import App from '../App.vue'

const home = r => require.ensure([], () => r(require('../page/home/home')), 'home')
const movies = r => require.ensure([], () => r(require('../page/movie/movies')), 'movies')
//video.js 报错
//const moviedetail = r => require.ensure([], () => r(require('../page/movie/detail')), 'moviedetail')
import moviedetail from '../page/movie/detail'

export default [{
    path: '/',
    component: App, //顶层路由，对应index.html
    children: [ //二级路由。对应App.vue
        //地址为空时跳转home页面
        {
            path: '',
            component: home
        },
        {
            path:'movies/:type',
            component:movies
        },
        {
            path:'movie/:id',
            component:moviedetail
        }
    ]
}]
