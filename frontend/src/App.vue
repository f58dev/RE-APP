<template>
  <div class="real-estate">
    <h1>Featured Properties</h1>

    <div class="properties">
      <div class="property-card" v-for="property in properties" :key="property.id">
        <img :src="property.image" :alt="property.title" />
        <h2>{{ property.title }}</h2>
        <p>Price: {{ property.price }}</p>
        <button>View Details</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'App',
  data() {
    return {
      properties: [
        {
          id: 1,
          title: "Luxury Villa in Dubai",
          price: "$2,000,000",
          image: "https://via.placeholder.com/300x200?text=Villa"
        },
        {
          id: 2,
          title: "Modern Apartment in Manama",
          price: "$350,000",
          image: "https://via.placeholder.com/300x200?text=Apartment"
        }
      ]
    };
  }
};
</script>

<style scoped>
.real-estate {
  font-family: Arial, sans-serif;
  padding: 20px;
}
.properties {
  display: flex;
  gap: 20px;
  flex-wrap: wrap;
}
.property-card {
  border: 1px solid #ddd;
  border-radius: 8px;
  padding: 16px;
  max-width: 300px;
}
.property-card img {
  width: 100%;
  border-radius: 6px;
}
</style>