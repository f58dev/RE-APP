import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import PropertyDetails from '../views/PropertyDetails.vue'
import AddProperty from '../views/AddProperty.vue'
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
  },
  {
    path: '/add',
    name: 'add-property',
    component: AddProperty
  }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router