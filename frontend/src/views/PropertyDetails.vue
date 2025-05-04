<template>
  <div v-if="property">
    <h1>{{ property.name }}</h1> 
    <p><strong>Location:</strong> {{ property.location }}</p>
    <p><strong>Price Per Night:</strong> {{ property.pricePerNight }}$</p>
    <p><strong>Description:</strong> {{ property.description }}</p>
  </div>
  <div v-else>
    Loading Property Details...
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { useRoute } from 'vue-router'

const route = useRoute()
const property = ref(null)

onMounted(() => {
  fetch('http://localhost:5286/properties')
    .then(res => res.json())
    .then(data => {
      property.value = data.find(p => p.id == route.params.id)
    })
    .catch(err => console.error("Error fetching property:", err))
})
</script>