import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import PropertyDetails from '../views/PropertyDetails.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/properties/:id',
    name: 'property-details',
    component: PropertyDetails
  }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router