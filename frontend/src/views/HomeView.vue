<template>
  <div>
    <h1>All Properties</h1>
    <ul>
      <li v-for="property in properties" :key="property.id">
        <strong>{{ property.name }}</strong> - {{ property.pricePerNight }}$
        <button @click="deleteProperty(property.id)">Delete</button>
        <p>{{ property.description }}</p>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: "HomeView",
  data() {
    return {
      properties: [],
    };
  },
  mounted() {
    fetch("http://localhost:5286/properties")
      .then((res) => res.json())
      .then((data) => {
        this.properties = data;
      })
      .catch((err) => {
        console.error("Failed to fetch properties:", err);
      });
  },
  methods: {
    deleteProperty(id) {
  if (confirm("Are you sure you want to delete this property?")) {
    fetch(`http://localhost:5286/properties/${id}`, {
      method: "DELETE",
    })
      .then((res) => {
        if (res.ok) {
          this.properties = this.properties.filter(p => p.id !== id);
        } else {
          console.log("Failed to delete property");
        }
      })
      .catch((err) => {
        console.error("Error deleting property", err);
      });
  }
}
  }
};
</script>