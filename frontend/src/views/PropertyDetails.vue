<template>
    <div v-if="property">
      <h2>{{ property.name }}</h2>
      <p><strong>Location:</strong> {{ property.location }}</p>
      <p><strong>Price:</strong> {{ property.pricePerNight }}$</p>
      <p><strong>Description:</strong> {{ property.description }}</p>
    </div>
    <p v-else>Loading...</p>
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
        const id = parseInt(route.params.id)
        property.value = data.find(p => p.id === id)
      })
      .catch(err => {
        console.error('Error fetching property:', err)
      })
  })
  </script>