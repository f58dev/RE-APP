<template>
  <div v-if="property">
    <h1>{{ property.name }}</h1>
    <p><strong>Price:</strong> {{ property.pricePerNight }}$</p>
    <p><strong>Description:</strong> {{ property.description }}</p>
    <p><strong>Location:</strong> {{ property.location }}</p>
  </div>
  <div v-else>
    Loading Property Details...
  </div>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import { useRoute } from 'vue-router'

const route = useRoute()
const property = ref(null)

onMounted(() => {
  const id = route.params.id
  fetch(`http://localhost:5286/properties/${id}`)
    .then((res) => res.json())
    .then((data) => {
      property.value = data
    })
    .catch((err) => {
      console.error("Failed to fetch property:", err)
    })
})
</script>